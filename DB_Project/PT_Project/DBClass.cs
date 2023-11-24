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
            string connectionString = "User Id=ptadmin; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = COM4-018)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
            string commandString = "select C.*, P.P_Start || ' - ' || P.P_End as PT기간, TRUNC(P.P_End - SYSDATE) as PT남은일수 from consumer C join program P on C.U_NO = P.U_NO and C.U_NO = " + select;
            DBAdapter = new OracleDataAdapter(commandString, connectionString);
            MyCommandBuilder = new OracleCommandBuilder(DBAdapter);
            DS = new DataSet();
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
