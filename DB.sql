-- ���̺� ����
drop table consumerDiet purge;
drop table program purge;
drop table trainer purge;
drop table consumer purge;

-- consumer ���̺� ����
CREATE TABLE consumer (
    U_NO NUMBER(20) PRIMARY KEY,
    cname VARCHAR(20),
    cage NUMBER(20),
    cheight NUMBER(20),
    cweight NUMBER(20),
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
    P_Outline VARCHAR(100),
    P_Demand VARCHAR(100),
    CONSTRAINT FK_program_Consumer FOREIGN KEY (U_NO) REFERENCES consumer(U_NO),
    CONSTRAINT FK_program_Trainer FOREIGN KEY (T_NO) REFERENCES trainer(T_NO)
);

-- consumerDiet ���̺� ����
CREATE TABLE consumerDiet (
    P_NO NUMBER(20),
    P_date DATE,
    P_Menu VARCHAR(100),
    P_Grade NUMBER(20)  NULL,
    P_Feedback VARCHAR(100)  NULL,
    CONSTRAINT PK_consumerDiet PRIMARY KEY (P_NO, P_date),
    CONSTRAINT FK_consumerDiet_Program FOREIGN KEY (P_NO) REFERENCES program(P_NO)
);

-- consumer ���̺� �߰�
insert into consumer values(1001, 'ȫ�浿', 20, 177, 70, '010-111-1111');
insert into consumer values(1002, '�ڱ浿', 21, 182, 73, '010-222-2222');
insert into consumer values(1003, '�̱浿', 22, 186, 77, '010-333-3333');
insert into consumer values(1004, '��浿', 23, 170, 70, '010-444-4444');
insert into consumer values(1005, '�ӱ浿', 26, 174, 72, '010-555-5555');
insert into consumer values(1006, '��浿', 24, 175, 76, '010-666-6666');
insert into consumer values(1007, '���浿', 22, 157, 63, '010-777-7777');
insert into consumer values(1008, '�ֱ浿', 28, 180, 75, '010-888-8888');
insert into consumer values(1009, '���浿', 25, 172, 68, '010-999-9999');
insert into consumer values(1010, '��浿', 30, 185, 80, '010-1010-1010');
insert into consumer values(1011, '�ѱ浿', 31, 176, 72, '010-1111-1111');
insert into consumer values(1012, '�ձ浿', 27, 168, 65, '010-1212-1212');
insert into consumer values(1013, '���浿', 29, 178, 78, '010-1313-1313');
insert into consumer values(1014, '���浿', 26, 181, 77, '010-1414-1414');
insert into consumer values(1015, '�ѱ浿', 24, 175, 70, '010-1515-1515');
insert into consumer values(1016, '���浿', 23, 179, 73, '010-1616-1616');
insert into consumer values(1017, '��浿', 32, 183, 82, '010-1717-1717');


-- trainer ���̺� �߰�
insert into trainer values(2001,'�迵��','010-9432-8842','12����');
insert into trainer values(2002,'���ȭ','010-8332-9242','7����');
insert into trainer values(2003,'����','010-1032-0982','12����');
insert into trainer values(2004,'�δ�','010-2432-6842','20����');

-- program ���̺� �߰�
insert into program values(3001,1001,2003,'2003-08-28','2023-08-29','2024-04-12','��̹�pt','�� 5�� � ��ħ-�߰�����100g ����-����2��');
insert into program values(3002,1003,2004,'2023-09-27','2023-09-28','2024-03-12','������pt','�� 6�� � ��ħ-����1��,�ٳ��� ����-�ܹ���������');
insert into program values(3003,1004,2003,'2023-08-11','2023-08-12','2024-01-11','��̹�pt','�� 5�� � ��ħ-�߰�����100g ����-���̹�1����');
insert into program values(3004,1002,2003,'2023-08-11','2023-08-12','2024-01-11','������pt','�� 6�� � ��ħ-����1��,�ٳ��� ����-�ܹ�����������');
insert into program values(3005,1005,2003,'2023-08-11','2023-08-12','2024-01-11','���̾�Ʈ��pt','�� 6�� � ��ħ-�߰�����100g ����-���̹�1����');
insert into program values(3006,1006,2003,'2023-08-11','2023-08-12','2024-01-11','���̾�Ʈ��pt','�� 6�� ���ħ-����1��,�ٳ��� ����-�ܹ�����������');
insert into program values(3007,1007,2003,'2023-08-11','2023-08-12','2024-01-11','��̹�pt','�� 4�� � ��ħ-�߰�����100g ����-���̹�1����');
insert into program values(3008,1008,2001,'2023-12-08','2023-12-12','2024-06-08','���̾�Ʈ��pt','�� 6�� � ��ħ-��, ����-����');
insert into program values(3009,1009,2002,'2023-12-09','2023-12-13','2024-06-09','������pt','�� 5�� � ��ħ-�߰�����, ����-ä�һ�����');
insert into program values(3010,1010,2004,'2023-12-10','2023-12-14','2024-06-10','���̾�Ʈ��pt','�� 6�� � ��ħ-�丶��, ����-�ܹ���������');
insert into program values(3011,1011,2001,'2023-12-11','2023-12-15','2024-06-11','��̹�pt','�� 3�� � ��ħ-���ϻ�����, ����-�߰���');
insert into program values(3012,1012,2002,'2023-12-12','2023-12-16','2024-06-12','������pt','�� 5�� � ��ħ-���ݸ�, ����-����ƾ��');
insert into program values(3013,1013,2004,'2023-12-13','2023-12-17','2024-06-13','���̾�Ʈ��pt','�� 6�� � ��ħ-�ٳ���, ����-���Ʈ');
insert into program values(3014,1014,2001,'2023-12-14','2023-12-18','2024-06-14','��̹�pt','�� 5�� � ��ħ-��, ����-���ϻ�����');
insert into program values(3015,1015,2002,'2023-12-15','2023-12-19','2024-06-15','������pt','�� 5�� � ��ħ-�߰�����, ����-ä�һ�����');
insert into program values(3016,1016,2004,'2023-12-16','2023-12-20','2024-06-16','���̾�Ʈ��pt','�� 6�� � ��ħ-�丶��, ����-�ܹ���������');
insert into program values(3017,1017,2001,'2023-12-17','2023-12-21','2024-06-17','��̹�pt','�� 4�� � ��ħ-���ϻ�����, ����-�߰���');

-- consumerDiet ���̺� �߰�
INSERT INTO consumerDiet VALUES (3001, '2023-12-01', '���ϻ�����@�ܹ���������@��� 2��', 5, '�پ缺�� ���� �Ĵ��Դϴ�.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-02', '�߰����������@���̾�Ʈ��@�߰�����100g', 4, '�Ĵ� �پ缺�� ���̴� ����� �ʿ��� �� ���ƿ�.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-03', '���ϻ�����@�ܹ���������@��� 2��', 3, '�Ĵ��� ������ ���� �� ����غ�����.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-04', '����ƾ����ũ@�߰����������@��ȣ��', 5, '�� �������ּ���.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-05', '���ϻ�����@�ܹ���������@������', 2, '�Ĵܿ� ���� �� �پ缺�� ���� �� ���� �� �����ϴ�.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-06', '�丶�������@�߰�����100g@��� 2��', 4, '�Ĵ� �پ缺�� ����غ�����.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-07', '���ϻ�����@�ܹ���������@�߰�����100g', 3, '�߰������� ������ ���Դϴ�.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-08', '�丶�������@���̾�Ʈ��@��Ʈ��', 5, '��� �̷��� �Ĵ��� �������ּ���.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-09', '���ϻ�����@�ܹ���������@�߰�����100g', 4, '���� �� �Ĵ� �پ缺�� ���غ�����.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-10', '�߰�����100g@���̾�Ʈ��@��� 2��', 3, '�Ĵ��� ������ ���Դϴ�.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-11', '���ϻ�����@�ܹ���������@��� 2��', 5, '�پ缺�� ���� �Ĵ��Դϴ�.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-12', '�߰����������@���̾�Ʈ��@�߰�����100g', 4, '�Ĵ� �پ缺�� ���̴� ����� �ʿ��� �� ���ƿ�.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-13', '���ϻ�����@�ܹ���������@��� 2��', 3, '�Ĵ��� ������ ���� �� ����غ�����.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-14', '����ƾ����ũ@�߰����������@��ȣ��', 5, '�� �������ּ���.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-15', '���ϻ�����@�ܹ���������@������', 2, '�Ĵܿ� ���� �� �پ缺�� ���� �� ���� �� �����ϴ�.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-16', '�丶�������@�߰�����100g@��� 2��', 4, '�Ĵ� �پ缺�� ����غ�����.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-17', '���ϻ�����@�ܹ���������@�߰�����100g', 3, '�߰������� ������ ���Դϴ�.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-18', '�丶�������@���̾�Ʈ��@��Ʈ��', 5, '��� �̷��� �Ĵ��� �������ּ���.');
INSERT INTO consumerDiet VALUES (3001, '2023-12-19', '���ϻ�����@�ܹ���������@�߰�����100g', NULL, NULL);
INSERT INTO consumerDiet VALUES (3001, '2023-12-20', '�丶�������@���̾�Ʈ��@��Ʈ��', NULL, NULL);
INSERT INTO consumerDiet VALUES (3001, '2023-12-21', '���ϻ�����@�ܹ���������@��� 2��', NULL, NULL);
INSERT INTO consumerDiet VALUES (3001, '2023-12-22', '�߰����������@���̾�Ʈ��@�߰�����100g', NULL, NULL);
INSERT INTO consumerDiet VALUES (3001, '2023-12-23', '���ϻ�����@�ܹ���������@��� 2��', NULL, NULL);
INSERT INTO consumerDiet VALUES (3001, '2023-12-24', '����ƾ����ũ@�߰����������@��ȣ��', NULL, NULL);
INSERT INTO consumerDiet VALUES (3001, '2023-12-25', '���ϻ�����@�ܹ���������@������', NULL, NULL);
INSERT INTO consumerDiet VALUES (3001, '2023-12-26', '�丶�������@�߰�����100g@��� 2��', NULL, NULL);
INSERT INTO consumerDiet VALUES (3001, '2023-12-27', '���ϻ�����@�ܹ���������@�߰�����100g', NULL, NULL);
INSERT INTO consumerDiet VALUES (3001, '2023-12-28', '�丶�������@���̾�Ʈ��@��Ʈ��', NULL, NULL);
INSERT INTO consumerDiet VALUES (3001, '2023-12-29', '���ϻ�����@�ܹ���������@�߰�����100g', NULL, NULL);
INSERT INTO consumerDiet VALUES (3001, '2023-12-30', '�߰�����100g@���̾�Ʈ��@��� 2��', NULL, NULL);
INSERT INTO consumerDiet VALUES (3001, '2023-12-31', '���ϻ�����@�ܹ���������@������', NULL, NULL);
INSERT INTO consumerDiet VALUES (3002, '2023-12-01', '���ϻ�����@�ܹ���������@��� 2��', 5, '�پ缺�� ���� �Ĵ��Դϴ�.');
INSERT INTO consumerDiet VALUES (3002, '2023-12-02', '�߰����������@���̾�Ʈ��@�߰�����100g', NULL, NULL);
INSERT INTO consumerDiet VALUES (3003, '2023-12-03', '���ϻ�����@�ܹ���������@��� 2��', 3, '�Ĵ��� ������ ���� �� ����غ�����.');
INSERT INTO consumerDiet VALUES (3003, '2023-12-04', '����ƾ����ũ@�߰����������@��ȣ��', 5, '�� �������ּ���.');
INSERT INTO consumerDiet VALUES (3004, '2023-12-05', '���ϻ�����@�ܹ���������@������', 2, '�Ĵܿ� ���� �� �پ缺�� ���� �� ���� �� �����ϴ�.');
INSERT INTO consumerDiet VALUES (3004, '2023-12-06', '�丶�������@�߰�����100g@��� 2��', 4, '�Ĵ� �پ缺�� ����غ�����.');
INSERT INTO consumerDiet VALUES (3005, '2023-12-07', '���ϻ�����@�ܹ���������@�߰�����100g', 3, '�߰������� ������ ���Դϴ�.');
INSERT INTO consumerDiet VALUES (3005, '2023-12-08', '�丶�������@���̾�Ʈ��@��Ʈ��', 5, '��� �̷��� �Ĵ��� �������ּ���.');
INSERT INTO consumerDiet VALUES (3006, '2023-12-09', '���ϻ�����@�ܹ���������@�߰�����100g', 4, '���� �� �Ĵ� �پ缺�� ���غ�����.');
INSERT INTO consumerDiet VALUES (3006, '2023-12-10', '�߰�����100g@���̾�Ʈ��@��� 2��', 3, '�Ĵ��� ������ ���Դϴ�.');
INSERT INTO consumerDiet VALUES (3007, '2023-12-11', '���ϻ�����@�ܹ���������@��� 2��', 5, '�پ缺�� ���� �Ĵ��Դϴ�.');
INSERT INTO consumerDiet VALUES (3007, '2023-12-12', '�߰����������@���̾�Ʈ��@�߰�����100g', 4, '�Ĵ� �پ缺�� ���̴� ����� �ʿ��� �� ���ƿ�.');
INSERT INTO consumerDiet VALUES (3008, '2023-12-13', '���ϻ�����@�ܹ���������@��� 2��', NULL, NULL);
INSERT INTO consumerDiet VALUES (3008, '2023-12-14', '����ƾ����ũ@�߰����������@��ȣ��', 5, '�� �������ּ���.');
INSERT INTO consumerDiet VALUES (3009, '2023-12-15', '���ϻ�����@�ܹ���������@��� 2��', 3, '�Ĵ��� ������ ���� �� ����غ�����.');
INSERT INTO consumerDiet VALUES (3009, '2023-12-16', '�丶�������@���̾�Ʈ��@��Ʈ��', NULL, NULL);
INSERT INTO consumerDiet VALUES (3010, '2023-12-17', '���ϻ�����@�ܹ���������@��� 2��', 5, '�� �������ּ���.');
INSERT INTO consumerDiet VALUES (3010, '2023-12-18', '�丶�������@���̾�Ʈ��@��Ʈ��', NULL, NULL);
INSERT INTO consumerDiet VALUES (3011, '2023-12-19', '���ϻ�����@�ܹ���������@��� 2��', 4, '���� �� �Ĵ� �پ缺�� ���غ�����.');
INSERT INTO consumerDiet VALUES (3011, '2023-12-20', '�߰����������@���̾�Ʈ��@�߰�����100g', NULL, NULL);
INSERT INTO consumerDiet VALUES (3012, '2023-12-21', '���ϻ�����@�ܹ���������@��� 2��', 3, '�Ĵ��� ������ ���Դϴ�.');
INSERT INTO consumerDiet VALUES (3012, '2023-12-22', '�߰����������@���̾�Ʈ��@�߰�����100g', NULL, NULL);
INSERT INTO consumerDiet VALUES (3013, '2023-12-23', '���ϻ�����@�ܹ���������@��� 2��', 5, '�پ缺�� ���� �Ĵ��Դϴ�.');
INSERT INTO consumerDiet VALUES (3013, '2023-12-24', '����ƾ����ũ@�߰����������@��ȣ��', NULL, NULL);
INSERT INTO consumerDiet VALUES (3014, '2023-12-25', '���ϻ�����@�ܹ���������@��� 2��', 4, '�Ĵ� �پ缺�� ���̴� ����� �ʿ��� �� ���ƿ�.');
INSERT INTO consumerDiet VALUES (3014, '2023-12-26', '�丶�������@���̾�Ʈ��@��Ʈ��', NULL, NULL);
INSERT INTO consumerDiet VALUES (3015, '2023-12-27', '���ϻ�����@�ܹ���������@��� 2��', 3, '�Ĵ��� ������ ���� �� ����غ�����.');
INSERT INTO consumerDiet VALUES (3015, '2023-12-28', '�߰����������@���̾�Ʈ��@�߰�����100g', NULL, NULL);
INSERT INTO consumerDiet VALUES (3016, '2023-12-29', '���ϻ�����@�ܹ���������@��� 2��', 5, '�� �������ּ���.');
INSERT INTO consumerDiet VALUES (3016, '2023-12-30', '�丶�������@���̾�Ʈ��@��Ʈ��', NULL, NULL);
INSERT INTO consumerDiet VALUES (3017, '2023-12-31', '���ϻ�����@�ܹ���������@��� 2��', 4, '���� �� �Ĵ� �پ缺�� ���غ�����.');
INSERT INTO consumerDiet VALUES (3017, '2024-01-01', '�߰����������@���̾�Ʈ��@�߰�����100g', NULL, NULL);



