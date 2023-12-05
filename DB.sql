-- 테이블 삭제
drop table consumerDiet purge;
drop table program purge;
drop table trainer purge;
drop table consumer purge;

-- consumer 테이블 생성
CREATE TABLE consumer (
    U_NO NUMBER(20) PRIMARY KEY,
    cname VARCHAR(20),
    cage VARCHAR(20),
    cheight VARCHAR(10),
    cweight VARCHAR(10),
    phone VARCHAR(20)
);


-- trainer 테이블 생성
CREATE TABLE trainer (
    T_NO NUMBER(20) PRIMARY KEY,
    T_Name VARCHAR(20),
    T_PhoneNum VARCHAR(20),
    T_Career VARCHAR(100)
);

-- program 테이블 생성
CREATE TABLE program (
    P_NO NUMBER(20) PRIMARY KEY,
    U_NO NUMBER(20),
    T_NO NUMBER(20),
    P_Contract DATE,
    P_Start DATE,
    P_End DATE,
    P_Outline VARCHAR(70),
    P_Demand VARCHAR(70),
    CONSTRAINT FK_program_Consumer FOREIGN KEY (U_NO) REFERENCES consumer(U_NO),
    CONSTRAINT FK_program_Trainer FOREIGN KEY (T_NO) REFERENCES trainer(T_NO)
);

-- consumerDiet 테이블 생성
CREATE TABLE consumerDiet (
    U_NO NUMBER(20),
    P_date DATE,
    P_NO NUMBER(20),
    T_NO NUMBER(20),
    P_Menu VARCHAR(100),
    P_Grade NUMBER(20)  NULL,
    P_Feedback VARCHAR(100)  NULL,
    CONSTRAINT PK_consumerDiet PRIMARY KEY (U_NO, P_date),
    CONSTRAINT FK_consumerDiet_Consumer FOREIGN KEY (U_NO) REFERENCES consumer(U_NO),
    CONSTRAINT FK_consumerDiet_Trainer FOREIGN KEY (T_NO) REFERENCES trainer(T_NO),
    CONSTRAINT FK_consumerDiet_Program FOREIGN KEY (P_NO) REFERENCES program(P_NO)
);

-- consumer 테이블 추가
insert into consumer values(1001, '홍길동', '20', '177', '70', '010-111-1111');
insert into consumer values(1002, '박길동', '21', '182', '73', '010-222-2222');
insert into consumer values(1003, '이길동', '22', '186', '77', '010-333-3333');
insert into consumer values(1004, '김길동', '23', '170', '70', '010-444-4444');
insert into consumer values(1005, '임길동', '26', '174', '72', '010-555-5555');
insert into consumer values(1006, '양길동', '24', '175', '76', '010-666-6666');
insert into consumer values(1007, '유길동', '22', '157', '63', '010-777-7777');

-- trainer 테이블 추가
insert into trainer values(2001,'김영우','010-9432-8842','12년차');
insert into trainer values(2002,'장덕화','010-8332-9242','7년차');
insert into trainer values(2003,'성윤','010-1032-0982','12년차');
insert into trainer values(2004,'로니','010-2432-6842','20년차');

-- program 테이블 추가
insert into program values(3001,1001,2003,'2003-08-28','2023-08-29','2024-04-12','취미반pt','아침-닭가슴살100g 저녁-고구마2개');
insert into program values(3002,1003,2004,'2023-09-27','2023-09-28','2024-03-12','선수반pt','아침-고구마1개,바나나 점심-단백질보충제');
insert into program values(3003,1004,2003,'2023-08-11','2023-08-12','2024-01-11','취미반pt','아침-닭가슴살50g 점심-현미밥1공기');
insert into program values(3004,1002,2003,'2023-08-11','2023-08-12','2024-01-11','선수반pt','아침-고구마1개,바나나 점심-단백질보충제기');
insert into program values(3005,1005,2003,'2023-08-11','2023-08-12','2024-01-11','다이어트반pt','아침-닭가슴살50g 점심-현미밥1공기');
insert into program values(3006,1006,2003,'2023-08-11','2023-08-12','2024-01-11','다이어트반pt','아침-고구마1개,바나나 점심-단백질보충제기');
insert into program values(3007,1007,2003,'2023-08-11','2023-08-12','2024-01-11','취미반pt','아침-닭가슴살50g 점심-현미밥1공기');

-- consumerDiet 테이블 추가
INSERT INTO consumerDiet VALUES (1001, '2023-12-01', 3001, 2003, '과일샐러드@단백질보충제@계란 2개', 5, '매우 만족합니다.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-02', 3001, 2003, '닭가슴살샐러드@다이어트바@닭가슴살', 4, '좋았습니다.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-03', 3001, 2003, '과일샐러드@단백질보충제@계란 2개', 3, '보통입니다.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-04', 3001, 2003, '프로틴쉐이크@닭가슴살샐러드@단호박', 5, '매우 만족합니다.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-05', 3001, 2003, '과일샐러드@단백질보충제@샐러드', 2, '불만족합니다.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-06', 3001, 2003, '토마토샐러드@닭가슴살@계란 2개', 4, '좋았습니다.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-07', 3001, 2003, '과일샐러드@단백질보충제@닭가슴살', 3, '보통입니다.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-08', 3001, 2003, '토마토샐러드@다이어트바@오트밀', 5, '매우 만족합니다.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-09', 3001, 2003, '과일샐러드@단백질보충제@닭가슴살', 4, '좋았습니다.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-10', 3001, 2003, '닭가슴살@다이어트바@계란 2개', 3, '보통입니다.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-11', 3001, 2003, '과일샐러드@단백질보충제@계란 2개', 5, '매우 만족합니다.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-12', 3001, 2003, '닭가슴살샐러드@다이어트바@닭가슴살', 4, '좋았습니다.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-13', 3001, 2003, '과일샐러드@단백질보충제@계란 2개', 3, '보통입니다.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-14', 3001, 2003, '프로틴쉐이크@닭가슴살샐러드@단호박', 5, '매우 만족합니다.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-15', 3001, 2003, '과일샐러드@단백질보충제@샐러드', 2, '불만족합니다.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-16', 3001, 2003, '토마토샐러드@닭가슴살@계란 2개', 4, '좋았습니다.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-17', 3001, 2003, '과일샐러드@단백질보충제@닭가슴살', 3, '보통입니다.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-18', 3001, 2003, '토마토샐러드@다이어트바@오트밀', 5, '매우 만족합니다.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-19', 3001, 2003, '과일샐러드@단백질보충제@닭가슴살', NULL, NULL);
INSERT INTO consumerDiet VALUES (1001, '2023-12-20', 3001, 2003, '토마토샐러드@다이어트바@오트밀', NULL, NULL);
INSERT INTO consumerDiet VALUES (1001, '2023-12-21', 3001, 2003, '과일샐러드@단백질보충제@계란 2개', NULL, NULL);
INSERT INTO consumerDiet VALUES (1001, '2023-12-22', 3001, 2003, '닭가슴살샐러드@다이어트바@닭가슴살', NULL, NULL);
INSERT INTO consumerDiet VALUES (1001, '2023-12-23', 3001, 2003, '과일샐러드@단백질보충제@계란 2개', NULL, NULL);
INSERT INTO consumerDiet VALUES (1001, '2023-12-24', 3001, 2003, '프로틴쉐이크@닭가슴살샐러드@단호박', NULL, NULL);
INSERT INTO consumerDiet VALUES (1001, '2023-12-25', 3001, 2003, '과일샐러드@단백질보충제@샐러드', NULL, NULL);
INSERT INTO consumerDiet VALUES (1001, '2023-12-26', 3001, 2003, '토마토샐러드@닭가슴살@계란 2개', NULL, NULL);
INSERT INTO consumerDiet VALUES (1001, '2023-12-27', 3001, 2003, '과일샐러드@단백질보충제@닭가슴살', NULL, NULL);
INSERT INTO consumerDiet VALUES (1001, '2023-12-28', 3001, 2003, '토마토샐러드@다이어트바@오트밀', NULL, NULL);
INSERT INTO consumerDiet VALUES (1001, '2023-12-29', 3001, 2003, '과일샐러드@단백질보충제@닭가슴살', NULL, NULL);
INSERT INTO consumerDiet VALUES (1001, '2023-12-30', 3001, 2003, '닭가슴살@다이어트바@계란 2개', NULL, NULL);
INSERT INTO consumerDiet VALUES (1001, '2023-12-31', 3001, 2003, '과일샐러드@단백질보충제@샐러드', NULL, NULL);




