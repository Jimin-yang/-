# CMD 입력부분 
sql> conn system/system
sql> create user ptadmin identified by 1111; sql> grant create session to ptadmin;
sql> grant resource, create view, create table to ptadmin;

sql> conn ptadmin/1111
sql> @ c:\ptadmin\DB.sql
Sql> commit; 