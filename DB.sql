-- ���̺� ����
drop table consumerDiet purge;
drop table program purge;
drop table trainer purge;
drop table consumer purge;

-- consumer ���̺� ����
CREATE TABLE consumer (
    U_NO NUMBER(20) PRIMARY KEY,
    cname VARCHAR(20),
    cage VARCHAR(20),
    cheight VARCHAR(10),
    cweight VARCHAR(10),
    phone VARCHAR(20)
);


-- trainer ���̺� ����
CREATE TABLE trainer (
    T_NO NUMBER(20) PRIMARY KEY,
    T_Name VARCHAR(20),
    T_PhoneNum VARCHAR(20),
    T_Career VARCHAR(100)
);

-- program ���̺� ����
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

-- consumerDiet ���̺� ����
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

-- consumer ���̺� �߰�
insert into consumer values(1001, 'ȫ�浿', '20', '177', '70', '010-111-1111');
insert into consumer values(1002, '�ڱ浿', '21', '182', '73', '010-222-2222');
insert into consumer values(1003, '�̱浿', '22', '186', '77', '010-333-3333');
insert into consumer values(1004, '��浿', '23', '170', '70', '010-444-4444');
insert into consumer values(1005, '�ӱ浿', '26', '174', '72', '010-555-5555');
insert into consumer values(1006, '��浿', '24', '175', '76', '010-666-6666');
insert into consumer values(1007, '���浿', '22', '157', '63', '010-777-7777');

-- trainer ���̺� �߰�
insert into trainer values(2001,'�迵��','010-9432-8842','12����');
insert into trainer values(2002,'���ȭ','010-8332-9242','7����');
insert into trainer values(2003,'����','010-1032-0982','12����');
insert into trainer values(2004,'�δ�','010-2432-6842','20����');

-- program ���̺� �߰�
insert into program values(3001,1001,2003,'2003-08-28','2023-08-29','2024-04-12','��̹�pt','��ħ-�߰�����100g ����-����2��');
insert into program values(3002,1003,2004,'2023-09-27','2023-09-28','2024-03-12','������pt','��ħ-����1��,�ٳ��� ����-�ܹ���������');
insert into program values(3003,1004,2003,'2023-08-11','2023-08-12','2024-01-11','��̹�pt','��ħ-�߰�����50g ����-���̹�1����');
insert into program values(3004,1002,2003,'2023-08-11','2023-08-12','2024-01-11','������pt','��ħ-����1��,�ٳ��� ����-�ܹ�����������');
insert into program values(3005,1005,2003,'2023-08-11','2023-08-12','2024-01-11','���̾�Ʈ��pt','��ħ-�߰�����50g ����-���̹�1����');
insert into program values(3006,1006,2003,'2023-08-11','2023-08-12','2024-01-11','���̾�Ʈ��pt','��ħ-����1��,�ٳ��� ����-�ܹ�����������');
insert into program values(3007,1007,2003,'2023-08-11','2023-08-12','2024-01-11','��̹�pt','��ħ-�߰�����50g ����-���̹�1����');

-- consumerDiet ���̺� �߰�
INSERT INTO consumerDiet VALUES (1001, '2023-12-01', 3001, 2003, '���ϻ�����@�ܹ���������@��� 2��', 5, '�ſ� �����մϴ�.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-02', 3001, 2003, '�߰����������@���̾�Ʈ��@�߰�����', 4, '���ҽ��ϴ�.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-03', 3001, 2003, '���ϻ�����@�ܹ���������@��� 2��', 3, '�����Դϴ�.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-04', 3001, 2003, '����ƾ����ũ@�߰����������@��ȣ��', 5, '�ſ� �����մϴ�.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-05', 3001, 2003, '���ϻ�����@�ܹ���������@������', 2, '�Ҹ����մϴ�.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-06', 3001, 2003, '�丶�������@�߰�����@��� 2��', 4, '���ҽ��ϴ�.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-07', 3001, 2003, '���ϻ�����@�ܹ���������@�߰�����', 3, '�����Դϴ�.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-08', 3001, 2003, '�丶�������@���̾�Ʈ��@��Ʈ��', 5, '�ſ� �����մϴ�.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-09', 3001, 2003, '���ϻ�����@�ܹ���������@�߰�����', 4, '���ҽ��ϴ�.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-10', 3001, 2003, '�߰�����@���̾�Ʈ��@��� 2��', 3, '�����Դϴ�.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-11', 3001, 2003, '���ϻ�����@�ܹ���������@��� 2��', 5, '�ſ� �����մϴ�.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-12', 3001, 2003, '�߰����������@���̾�Ʈ��@�߰�����', 4, '���ҽ��ϴ�.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-13', 3001, 2003, '���ϻ�����@�ܹ���������@��� 2��', 3, '�����Դϴ�.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-14', 3001, 2003, '����ƾ����ũ@�߰����������@��ȣ��', 5, '�ſ� �����մϴ�.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-15', 3001, 2003, '���ϻ�����@�ܹ���������@������', 2, '�Ҹ����մϴ�.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-16', 3001, 2003, '�丶�������@�߰�����@��� 2��', 4, '���ҽ��ϴ�.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-17', 3001, 2003, '���ϻ�����@�ܹ���������@�߰�����', 3, '�����Դϴ�.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-18', 3001, 2003, '�丶�������@���̾�Ʈ��@��Ʈ��', 5, '�ſ� �����մϴ�.');
INSERT INTO consumerDiet VALUES (1001, '2023-12-19', 3001, 2003, '���ϻ�����@�ܹ���������@�߰�����', NULL, NULL);
INSERT INTO consumerDiet VALUES (1001, '2023-12-20', 3001, 2003, '�丶�������@���̾�Ʈ��@��Ʈ��', NULL, NULL);
INSERT INTO consumerDiet VALUES (1001, '2023-12-21', 3001, 2003, '���ϻ�����@�ܹ���������@��� 2��', NULL, NULL);
INSERT INTO consumerDiet VALUES (1001, '2023-12-22', 3001, 2003, '�߰����������@���̾�Ʈ��@�߰�����', NULL, NULL);
INSERT INTO consumerDiet VALUES (1001, '2023-12-23', 3001, 2003, '���ϻ�����@�ܹ���������@��� 2��', NULL, NULL);
INSERT INTO consumerDiet VALUES (1001, '2023-12-24', 3001, 2003, '����ƾ����ũ@�߰����������@��ȣ��', NULL, NULL);
INSERT INTO consumerDiet VALUES (1001, '2023-12-25', 3001, 2003, '���ϻ�����@�ܹ���������@������', NULL, NULL);
INSERT INTO consumerDiet VALUES (1001, '2023-12-26', 3001, 2003, '�丶�������@�߰�����@��� 2��', NULL, NULL);
INSERT INTO consumerDiet VALUES (1001, '2023-12-27', 3001, 2003, '���ϻ�����@�ܹ���������@�߰�����', NULL, NULL);
INSERT INTO consumerDiet VALUES (1001, '2023-12-28', 3001, 2003, '�丶�������@���̾�Ʈ��@��Ʈ��', NULL, NULL);
INSERT INTO consumerDiet VALUES (1001, '2023-12-29', 3001, 2003, '���ϻ�����@�ܹ���������@�߰�����', NULL, NULL);
INSERT INTO consumerDiet VALUES (1001, '2023-12-30', 3001, 2003, '�߰�����@���̾�Ʈ��@��� 2��', NULL, NULL);
INSERT INTO consumerDiet VALUES (1001, '2023-12-31', 3001, 2003, '���ϻ�����@�ܹ���������@������', NULL, NULL);




