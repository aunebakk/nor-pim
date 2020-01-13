--https://localhost:44341
insert into default_test (default_test_id, system_name, test_area, test_sub_area, test_address, user_id, date_time)
                  values (newid(), 'NorPim', 'Pim', 'Test', 'https://localhost:44341', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate() );
