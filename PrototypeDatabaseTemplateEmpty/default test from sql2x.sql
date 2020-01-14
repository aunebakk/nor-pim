--https://NorSolutionPim.azurewebsites.net
insert into default_test (default_test_id, system_name, test_area, test_sub_area, test_address, user_id, date_time)
                  values (newid(), 'NorPim', 'Pim', 'Test', 'https://NorSolutionPim.azurewebsites.net', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate() );
