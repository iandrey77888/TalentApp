import java.net.URI;
import java.net.URISyntaxException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;

public class Main {
    public static void main(String[] args) throws URISyntaxException, SQLException {
        URI dbUri = new URI("postgres://cvefxnsgsrwszw:932a6c8d69232b10460e0c12f42e0b68f5b38efe152f1a638e3bd68b3517c6f3@ec2-54-246-115-40.eu-west-1.compute.amazonaws.com:5432/dlaqnc2elhvb6");

        String username = dbUri.getUserInfo().split(":")[0];
        String password = dbUri.getUserInfo().split(":")[1];
        String dbUrl = "jdbc:postgresql://" + dbUri.getHost() + ':' + dbUri.getPort() + dbUri.getPath() + "?sslmode=require";

        Connection conn = DriverManager.getConnection(dbUrl, username, password);
        ResultSet set = conn.createStatement(ResultSet.TYPE_SCROLL_INSENSITIVE,
                ResultSet.CONCUR_UPDATABLE).executeQuery("select * from test");
        set.next(); set.next();
        System.out.println(set.getInt(1));
    }
}
