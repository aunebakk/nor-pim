/*  database management for sql2x solutions */
using System;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    public class DatabaseVersion : IEquatable<DatabaseVersion> {
        public int MajorNumber;
        public int MinorNumber;
        public int SequenceNumber;
        public DateTime DateTime;

        // convert database version to dotNetVersion
        // Source: https://stackoverflow.com/questions/7568147/compare-version-numbers-without-using-split-function 
        private Version DotNetVersion => new Version(major: MajorNumber, minor: MinorNumber, build: SequenceNumber);

        public static DatabaseVersion FetchVersion(
            string connectionManager
            ) {
            return new DatabaseVersion { MajorNumber = 0, MinorNumber = 0, SequenceNumber = 1 };
        }

        // return new object with sequence number increased
        internal DatabaseVersion SequenceIncrease => new DatabaseVersion { MajorNumber = MajorNumber, MinorNumber = MinorNumber, SequenceNumber = SequenceNumber++, DateTime = DateTime };

        public static bool operator ==(DatabaseVersion obj1, DatabaseVersion obj2) {
            return (obj1.DotNetVersion == obj2.DotNetVersion);
        }

        // this is second one '!='
        public static bool operator !=(DatabaseVersion obj1, DatabaseVersion obj2) {
            return !(obj1.DotNetVersion == obj2.DotNetVersion);
        }

        public static bool operator <(DatabaseVersion obj1, DatabaseVersion obj2) {
            return obj1.DotNetVersion < obj2.DotNetVersion;
        }

        public static bool operator >(DatabaseVersion obj1, DatabaseVersion obj2) {
            return obj1.DotNetVersion > obj2.DotNetVersion;
        }

        public static bool operator >=(DatabaseVersion obj1, DatabaseVersion obj2) {
            return obj1.DotNetVersion >= obj2.DotNetVersion;
        }

        public static bool operator <=(DatabaseVersion obj1, DatabaseVersion obj2) {
            return obj1.DotNetVersion <= obj2.DotNetVersion;
        }

        public bool Equals(DatabaseVersion other) {
            if (ReferenceEquals(null, other)) {
                return false;
            }
            if (ReferenceEquals(this, other)) {
                return true;
            }

            return MajorNumber.Equals(other.MajorNumber)
                   && MinorNumber.Equals(other.MinorNumber)
                   && SequenceNumber.Equals(other.SequenceNumber);
        }

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) {
                return false;
            }
            if (ReferenceEquals(this, obj)) {
                return true;
            }

            return obj.GetType() == GetType() && Equals((DatabaseVersion)obj);
        }

        public override int GetHashCode() {
            unchecked {
                int hashCode = MajorNumber.GetHashCode();
                hashCode = (hashCode * 397) ^ MinorNumber.GetHashCode();
                hashCode = (hashCode * 397) ^ SequenceNumber.GetHashCode();
                return hashCode;
            }
        }

        public override string ToString() {
            return MajorNumber.ToString() + "." + MinorNumber.ToString() + "." + SequenceNumber.ToString();
        }
    }

    public partial class DatabaseManager {
        private void InitVersioning(
            int majorNumber,
            int minorNumber
            ) {
            int sequence = 0;

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = defaultVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 01, 21) },
                ScriptNumber = scriptNumber++,
                Name = "Versioning",
                Description = "Database Versioning",
                #region script ( default_version )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
                            if object_id (N'default_version') is not null
                                drop table default_version
                            go
                            create table default_version (
	                            default_version_id uniqueidentifier not null primary key clustered (default_version_id asc),
	                            fun_version varchar(20) not null,
	                            number varchar(20) not null,
	                            major_number int not null,
	                            minor_number int not null,
	                            sequence_number int not null,
	                            default_user_id uniqueidentifier null ,
	                            date_time datetime not null 
                                )
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2016, 01, 01) },
                ScriptNumber = scriptNumber++,
                Name = "Default",
                Description = "Part of Default sql2x Tables",
                #region script ( default_user, default_state_ref )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
                            if object_id (N'default_user') is not null
                                drop table default_user 
                            go
                            if object_id (N'default_state_ref') is not null
                                drop table default_state_ref 
                            go
                            create table default_state_ref (
                                default_state_rcd  varchar ( 20 )  not null ,
                                default_state_name  nvarchar ( 240 )  not null ,
                                default_user_id  uniqueidentifier  null ,
                                date_time  datetime  not null ,
                                constraint  xpkdefault_state_ref primary key   clustered ( default_state_rcd  asc )
                            )
                            go
                            -- default_state_ref
                            insert into default_state_ref( default_state_rcd, default_state_name, date_time)
                                values ( 'C' , 'Created' , getutcdate () );

                            insert into default_state_ref ( default_state_rcd , default_state_name , date_time )
                                values ( 'U' , 'Updated' , getutcdate () );

                            insert into default_state_ref ( default_state_rcd , default_state_name , date_time )
                                values ( 'I' , 'Invalidated' , getutcdate () );
                            go
                            create table default_user (
                                default_user_id  uniqueidentifier  not null ,
                                default_user_code  varchar ( 20 )  not null ,
                                default_user_name  nvarchar ( 240 )  not null ,
                                email  nvarchar ( 240 )  null ,
                                password  nvarchar ( 240 )  null ,
                                default_state_rcd  varchar ( 20 )  not null ,
                                created_by_default_user_id  uniqueidentifier  null ,
                                date_time  datetime  not null ,
                                last_activity_date_time  datetime  null ,
                                constraint  xpkdefault_user primary key   clustered ( default_user_id  asc ) ,
                                constraint  default_user_to_created_by_default_user foreign key ( created_by_default_user_id ) references default_user ( default_user_id ) ,
                                constraint  default_user_to_default_state foreign key ( default_state_rcd ) references default_state_ref ( default_state_rcd )
                            )
                            go

                            -- default_user
                            insert into default_user (default_user_id, default_user_code, default_user_name, default_state_rcd, created_by_default_user_id, date_time) 
	                            values ('{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', 'SUX', 'System user X', 'C', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            go
                            if object_id ( N'dbo.ref' ) is not null begin
                                drop function dbo.ref
                            end
                            go
                            create function dbo.ref (@ref_code nvarchar(240)) 
                            returns nvarchar(240) as begin
                                return right ( @ref_code , len ( @ref_code ) - charindex ( '.' , @ref_code ) )
                            end
                            go
                            if object_id (N'get_defaults') is not null begin
	                            drop procedure get_defaults
                            end
                            go
                            create procedure get_defaults (@user_id uniqueidentifier out) as begin
	                            -- base
	                            set @user_id = '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}'
                            end
                            go
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });
        }

        public string DefaultVersion(
            DatabaseVersion databaseVersion
            ) {

            string sql =
@"
insert into default_version (default_version_id, fun_version, number, major_number, minor_number, sequence_number, default_user_id, date_time) 
	values (
        newid(), 
        'initVersion', 
        '" + databaseVersion.MajorNumber + "." + databaseVersion.MinorNumber + "." + databaseVersion.SequenceNumber + @"', 
        " + databaseVersion.MajorNumber + @", 
        " + databaseVersion.MinorNumber + @", 
        " + databaseVersion.SequenceNumber + @", 
        '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate())
";

            Execute(
                sql: sql
                );

            return "Script Executed" + " " + "( setting version '" + databaseVersion.MajorNumber + "." + databaseVersion.MinorNumber + "." + databaseVersion.SequenceNumber + "' )";
        }

        public string DefaultVersion(
            int major,
            int minor,
            int sequence
            ) {

            string sql =
@"
insert into default_version (default_version_id, fun_version, number, major_number, minor_number, sequence_number, default_user_id, date_time) 
	values (
        newid(), 
        'initVersion', 
        '" + major + "." + minor + "." + sequence + @"', 
        " + major + @", 
        " + minor + @", 
        " + sequence + @", 
        '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate())
";

            Execute(
                sql: sql
                );

            return "Script Executed" + " " + "( setting version '" + major + "." + minor + "." + sequence + "' )";
        }

    }
}
