-- 테이블 삭제
drop table consumerDiet purge;
drop table program purge;
drop table trainer purge;
drop table consumer purge;

-- consumer 테이블 생성
CREATE TABLE consumer (
    U_NO NUMBER(20) PRIMARY KEY,
    cname VARCHAR(20),
    cage NUMBER(20),
    cheight NUMBER(20),
    cweight NUMBER(20),
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
    P_Outline VARCHAR(100),
    P_Demand VARCHAR(100),
    CONSTRAINT FK_program_Consumer FOREIGN KEY (U_NO) REFERENCES consumer(U_NO),
    CONSTRAINT FK_program_Trainer FOREIGN KEY (T_NO) REFERENCES trainer(T_NO)
);

-- consumerDiet 테이블 생성
CREATE TABLE consumerDiet (
    P_NO NUMBER(20),
    P_date DATE,
    P_Menu VARCHAR(100),
    P_Grade NUMBER(20)  NULL,
    P_Feedback VARCHAR(100)  NULL,
    CONSTRAINT PK_consumerDiet PRIMARY KEY (P_NO, P_date),
    CONSTRAINT FK_consumerDiet_Program FOREIGN KEY (P_NO) REFERENCES program(P_NO)
);

-- consumer 테이블 추가
insert into consumer values(1001, '홍길동', 20, 177, 70, '010-111-1111');
insert into consumer values(1002, '박길동', 21, 182, 73, '010-222-2222');
insert into consumer values(1003, '이길동', 22, 186, 77, '010-333-3333');
insert into consumer values(1004, '김길동', 23, 170, 70, '010-444-4444');
insert into consumer values(1005, '임길동', 26, 174, 72, '010-555-5555');
insert into consumer values(1006, '양길동', 24, 175, 76, '010-666-6666');
insert into consumer values(1007, '유길동', 22, 157, 63, '010-777-7777');
insert into consumer values(1008, '최길동', 28, 180, 75, '010-888-8888');
insert into consumer values(1009, '정길동', 25, 172, 68, '010-999-9999');
insert into consumer values(1010, '배길동', 30, 185, 80, '010-1010-1010');
insert into consumer values(1011, '한길동', 31, 176, 72, '010-1111-1111');
insert into consumer values(1012, '손길동', 27, 168, 65, '010-1212-1212');
insert into consumer values(1013, '오길동', 29, 178, 78, '010-1313-1313');
insert into consumer values(1014, '조길동', 26, 181, 77, '010-1414-1414');
insert into consumer values(1015, '한길동', 24, 175, 70, '010-1515-1515');
insert into consumer values(1016, '유길동', 23, 179, 73, '010-1616-1616');
insert into consumer values(1017, '김길동', 32, 183, 82, '010-1717-1717');


-- trainer 테이블 추가
insert into trainer values(2001,'김영우','010-9432-8842','12년차');
insert into trainer values(2002,'장덕화','010-8332-9242','7년차');
insert into trainer values(2003,'성윤','010-1032-0982','12년차');
insert into trainer values(2004,'로니','010-2432-6842','20년차');

-- program 테이블 추가
insert into program values(3001,1001,2003,'2003-08-28','2023-08-29','2024-04-12','취미반pt','주 5일 운동 아침-닭가슴살100g 저녁-고구마2개');
insert into program values(3002,1003,2004,'2023-09-27','2023-09-28','2024-03-12','선수반pt','주 6일 운동 아침-고구마1개,바나나 점심-단백질보충제');
insert into program values(3003,1004,2003,'2023-08-11','2023-08-12','2024-01-11','취미반pt','주 5일 운동 아침-닭가슴살100g 점심-현미밥1공기');
insert into program values(3004,1002,2003,'2023-08-11','2023-08-12','2024-01-11','선수반pt','주 6일 운동 아침-고구마1개,바나나 점심-단백질보충제기');
insert into program values(3005,1005,2003,'2023-08-11','2023-08-12','2024-01-11','다이어트반pt','주 6일 운동 아침-닭가슴살100g 점심-현미밥1공기');
insert into program values(3006,1006,2003,'2023-08-11','2023-08-12','2024-01-11','다이어트반pt','주 6일 운동아침-고구마1개,바나나 점심-단백질보충제기');
insert into program values(3007,1007,2003,'2023-08-11','2023-08-12','2024-01-11','취미반pt','주 4일 운동 아침-닭가슴살100g 점심-현미밥1공기');
insert into program values(3008,1008,2001,'2023-12-08','2023-12-12','2024-06-08','다이어트반pt','주 6일 운동 아침-차, 간식-과일');
insert into program values(3009,1009,2002,'2023-12-09','2023-12-13','2024-06-09','선수반pt','주 5일 운동 아침-닭가슴살, 점심-채소샐러드');
insert into program values(3010,1010,2004,'2023-12-10','2023-12-14','2024-06-10','다이어트반pt','주 6일 운동 아침-토마토, 간식-단백질보충제');
insert into program values(3011,1011,2001,'2023-12-11','2023-12-15','2024-06-11','취미반pt','주 3일 운동 아침-과일샐러드, 간식-견과류');
insert into program values(3012,1012,2002,'2023-12-12','2023-12-16','2024-06-12','선수반pt','주 5일 운동 아침-초콜릿, 간식-프로틴바');
insert into program values(3013,1013,2004,'2023-12-13','2023-12-17','2024-06-13','다이어트반pt','주 6일 운동 아침-바나나, 간식-요거트');
insert into program values(3014,1014,2001,'2023-12-14','2023-12-18','2024-06-14','취미반pt','주 5일 운동 아침-차, 간식-과일샐러드');
insert into program values(3015,1015,2002,'2023-12-15','2023-12-19','2024-06-15','선수반pt','주 5일 운동 아침-닭가슴살, 점심-채소샐러드');
insert into program values(3016,1016,2004,'2023-12-16','2023-12-20','2024-06-16','다이어트반pt','주 6일 운동 아침-토마토, 간식-단백질보충제');
insert into program values(3017,1017,2001,'2023-12-17','2023-12-21','2024-06-17','취미반pt','주 4일 운동 아침-과일샐러드, 간식-견과류');

-- consumerDiet 테이블 추가
INSERT INTO consumerDiet VALUES (3001, '2023-12-01', '과일샐러드@단백질보충제@계란 2개', 5, '다양성이 좋은 식단입니다.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-02', '닭가슴살샐러드@다이어트바@닭가슴살100g', 4, '식단 다양성을 높이는 노력이 필요할 것 같아요.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-03', '과일샐러드@단백질보충제@계란 2개', 3, '식단의 균형을 조금 더 고려해보세요.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-04', '프로틴쉐이크@닭가슴살샐러드@단호박', 5, '잘 유지해주세요.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-05', '과일샐러드@단백질보충제@샐러드', 2, '식단에 조금 더 다양성을 더할 수 있을 것 같습니다.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-06', '토마토샐러드@닭가슴살100g@계란 2개', 4, '식단 다양성을 고려해보세요.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-07', '과일샐러드@단백질보충제@닭가슴살100g', 3, '닭가슴살이 부족해 보입니다.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-08', '토마토샐러드@다이어트바@오트밀', 5, '계속 이렇게 식단을 유지해주세요.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-09', '과일샐러드@단백질보충제@닭가슴살100g', 4, '조금 더 식단 다양성을 더해보세요.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-10', '닭가슴살100g@다이어트바@계란 2개', 3, '식단이 괜찮아 보입니다.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-11', '과일샐러드@단백질보충제@계란 2개', 5, '다양성이 좋은 식단입니다.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-12', '닭가슴살샐러드@다이어트바@닭가슴살100g', 4, '식단 다양성을 높이는 노력이 필요할 것 같아요.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-13', '과일샐러드@단백질보충제@계란 2개', 3, '식단의 균형을 조금 더 고려해보세요.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-14', '프로틴쉐이크@닭가슴살샐러드@단호박', 5, '잘 유지해주세요.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-15', '과일샐러드@단백질보충제@샐러드', 2, '식단에 조금 더 다양성을 더할 수 있을 것 같습니다.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-16', '토마토샐러드@닭가슴살100g@계란 2개', 4, '식단 다양성을 고려해보세요.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-17', '과일샐러드@단백질보충제@닭가슴살100g', 3, '닭가슴살이 부족해 보입니다.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-18', '토마토샐러드@다이어트바@오트밀', 5, '계속 이렇게 식단을 유지해주세요.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-19', '과일샐러드@단백질보충제@닭가슴살100g', NULL, NULL);
INSERT INTO consumerDiet VALUES (3001, '2023-12-20', '토마토샐러드@다이어트바@오트밀', NULL, NULL);
INSERT INTO consumerDiet VALUES (3001, '2023-12-21', '과일샐러드@단백질보충제@계란 2개', NULL, NULL);
INSERT INTO consumerDiet VALUES (3001, '2023-12-22', '닭가슴살샐러드@다이어트바@닭가슴살100g', NULL, NULL);
INSERT INTO consumerDiet VALUES (3001, '2023-12-23', '과일샐러드@단백질보충제@계란 2개', NULL, NULL);
INSERT INTO consumerDiet VALUES (3001, '2023-12-24', '프로틴쉐이크@닭가슴살샐러드@단호박', NULL, NULL);
INSERT INTO consumerDiet VALUES (3001, '2023-12-25', '과일샐러드@단백질보충제@샐러드', NULL, NULL);
INSERT INTO consumerDiet VALUES (3001, '2023-12-26', '토마토샐러드@닭가슴살100g@계란 2개', NULL, NULL);
INSERT INTO consumerDiet VALUES (3001, '2023-12-27', '과일샐러드@단백질보충제@닭가슴살100g', NULL, NULL);
INSERT INTO consumerDiet VALUES (3001, '2023-12-28', '토마토샐러드@다이어트바@오트밀', NULL, NULL);
INSERT INTO consumerDiet VALUES (3001, '2023-12-29', '과일샐러드@단백질보충제@닭가슴살100g', NULL, NULL);
INSERT INTO consumerDiet VALUES (3001, '2023-12-30', '닭가슴살100g@다이어트바@계란 2개', NULL, NULL);
INSERT INTO consumerDiet VALUES (3001, '2023-12-31', '과일샐러드@단백질보충제@샐러드', NULL, NULL);
INSERT INTO consumerDiet VALUES (3002, '2023-12-01', '과일샐러드@단백질보충제@계란 2개', 5, '다양성이 좋은 식단입니다.');
INSERT INTO consumerDiet VALUES (3002, '2023-12-02', '닭가슴살샐러드@다이어트바@닭가슴살100g', NULL, NULL);
INSERT INTO consumerDiet VALUES (3003, '2023-12-03', '과일샐러드@단백질보충제@계란 2개', 3, '식단의 균형을 조금 더 고려해보세요.');
INSERT INTO consumerDiet VALUES (3003, '2023-12-04', '프로틴쉐이크@닭가슴살샐러드@단호박', 5, '잘 유지해주세요.');
INSERT INTO consumerDiet VALUES (3004, '2023-12-05', '과일샐러드@단백질보충제@샐러드', 2, '식단에 조금 더 다양성을 더할 수 있을 것 같습니다.');
INSERT INTO consumerDiet VALUES (3004, '2023-12-06', '토마토샐러드@닭가슴살100g@계란 2개', 4, '식단 다양성을 고려해보세요.');
INSERT INTO consumerDiet VALUES (3005, '2023-12-07', '과일샐러드@단백질보충제@닭가슴살100g', 3, '닭가슴살이 부족해 보입니다.');
INSERT INTO consumerDiet VALUES (3005, '2023-12-08', '토마토샐러드@다이어트바@오트밀', 5, '계속 이렇게 식단을 유지해주세요.');
INSERT INTO consumerDiet VALUES (3006, '2023-12-09', '과일샐러드@단백질보충제@닭가슴살100g', 4, '조금 더 식단 다양성을 더해보세요.');
INSERT INTO consumerDiet VALUES (3006, '2023-12-10', '닭가슴살100g@다이어트바@계란 2개', 3, '식단이 괜찮아 보입니다.');
INSERT INTO consumerDiet VALUES (3007, '2023-12-11', '과일샐러드@단백질보충제@계란 2개', 5, '다양성이 좋은 식단입니다.');
INSERT INTO consumerDiet VALUES (3007, '2023-12-12', '닭가슴살샐러드@다이어트바@닭가슴살100g', 4, '식단 다양성을 높이는 노력이 필요할 것 같아요.');
INSERT INTO consumerDiet VALUES (3008, '2023-12-13', '과일샐러드@단백질보충제@계란 2개', NULL, NULL);
INSERT INTO consumerDiet VALUES (3008, '2023-12-14', '프로틴쉐이크@닭가슴살샐러드@단호박', 5, '잘 유지해주세요.');
INSERT INTO consumerDiet VALUES (3009, '2023-12-15', '과일샐러드@단백질보충제@계란 2개', 3, '식단의 균형을 조금 더 고려해보세요.');
INSERT INTO consumerDiet VALUES (3009, '2023-12-16', '토마토샐러드@다이어트바@오트밀', NULL, NULL);
INSERT INTO consumerDiet VALUES (3010, '2023-12-17', '과일샐러드@단백질보충제@계란 2개', 5, '잘 유지해주세요.');
INSERT INTO consumerDiet VALUES (3010, '2023-12-18', '토마토샐러드@다이어트바@오트밀', NULL, NULL);
INSERT INTO consumerDiet VALUES (3011, '2023-12-19', '과일샐러드@단백질보충제@계란 2개', 4, '조금 더 식단 다양성을 더해보세요.');
INSERT INTO consumerDiet VALUES (3011, '2023-12-20', '닭가슴살샐러드@다이어트바@닭가슴살100g', NULL, NULL);
INSERT INTO consumerDiet VALUES (3012, '2023-12-21', '과일샐러드@단백질보충제@계란 2개', 3, '식단이 괜찮아 보입니다.');
INSERT INTO consumerDiet VALUES (3012, '2023-12-22', '닭가슴살샐러드@다이어트바@닭가슴살100g', NULL, NULL);
INSERT INTO consumerDiet VALUES (3013, '2023-12-23', '과일샐러드@단백질보충제@계란 2개', 5, '다양성이 좋은 식단입니다.');
INSERT INTO consumerDiet VALUES (3013, '2023-12-24', '프로틴쉐이크@닭가슴살샐러드@단호박', NULL, NULL);
INSERT INTO consumerDiet VALUES (3014, '2023-12-25', '과일샐러드@단백질보충제@계란 2개', 4, '식단 다양성을 높이는 노력이 필요할 것 같아요.');
INSERT INTO consumerDiet VALUES (3014, '2023-12-26', '토마토샐러드@다이어트바@오트밀', NULL, NULL);
INSERT INTO consumerDiet VALUES (3015, '2023-12-27', '과일샐러드@단백질보충제@계란 2개', 3, '식단의 균형을 조금 더 고려해보세요.');
INSERT INTO consumerDiet VALUES (3015, '2023-12-28', '닭가슴살샐러드@다이어트바@닭가슴살100g', NULL, NULL);
INSERT INTO consumerDiet VALUES (3016, '2023-12-29', '과일샐러드@단백질보충제@계란 2개', 5, '잘 유지해주세요.');
INSERT INTO consumerDiet VALUES (3016, '2023-12-30', '토마토샐러드@다이어트바@오트밀', NULL, NULL);
INSERT INTO consumerDiet VALUES (3017, '2023-12-31', '과일샐러드@단백질보충제@계란 2개', 4, '조금 더 식단 다양성을 더해보세요.');
INSERT INTO consumerDiet VALUES (3017, '2024-01-01', '닭가슴살샐러드@다이어트바@닭가슴살100g', NULL, NULL);



