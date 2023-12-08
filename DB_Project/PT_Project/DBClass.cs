using Oracle.DataAccess.Client;
using System.Data;
using System.Windows.Forms;

public class DBClass
{
    private int selectedRowIndex;
    private int selectedKeyValue;
    OracleDataAdapter dBAdapter;
    DataSet dS;
    OracleCommandBuilder myCommandBuilder;
    DataTable consumerTable;

    public int SelectedRowIndex { get { return selectedRowIndex; } set { selectedRowIndex = value; } }
    public int SelectedKeyValue { get { return selectedKeyValue; } set { selectedKeyValue = value; } }
    public OracleDataAdapter DBAdapter { get { return dBAdapter; } set { dBAdapter = value; } }
    public DataSet DS { get { return dS; } set { dS = value; } }
    public OracleCommandBuilder MyCommandBuilder
    {
        get { return myCommandBuilder; }
        set { myCommandBuilder = value; }
    }
    public DataTable ConsumerTable { get { return consumerTable; } set { consumerTable = value; } }



    public void DB_Open(int select)
    {
        try
        {
            string connectionString = "User Id=ptadmin; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
            string commandString = "SELECT C.U_NO as 회원번호, C.cname as 이름, C.cage as 나이, C.cheight as 키, C.cweight as 몸무게, C.phone as 전화번호, P.P_Start || ' - ' || P.P_End as PT기간, TRUNC(P.P_End - SYSDATE) as PT남은일수 FROM consumer C JOIN program P ON C.U_NO = P.U_NO AND C.U_NO = " + select;


            DBAdapter = new OracleDataAdapter(commandString, connectionString);
            MyCommandBuilder = new OracleCommandBuilder(DBAdapter);
            DS = new DataSet();

            // DataTable에 데이터를 채워줍니다.
            DBAdapter.Fill(DS, "consumer");
            ConsumerTable = DS.Tables["consumer"];
        }
        catch (DataException DE)
        {
            MessageBox.Show(DE.Message);
        }
    }



    public void DB_ObjCreate()
    {
        consumerTable = new DataTable();
    }
}
