package es.iesmz.proyectoentradasalida.model; //EJERCICIO 1.2.4

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.Properties;

public class ConnectionDb {

    private Connection connection;
    private String servidor;
    private String usuario;
    private String password;
    private String driver;
    private String puerto;
    private String basedadatos;

    public ConnectionDb(){
        connection = null;
        servidor=usuario=password=driver=puerto=basedadatos="";

        cargarConfiguracion();
    }

    public Connection Conectar(){
        try {
            Class.forName(driver);
            connection = DriverManager.getConnection("jdbc:mysql://"+servidor+":"+puerto+"/"+basedadatos,usuario,password);

        } catch (ClassNotFoundException | SQLException e) {
            System.out.println("Error: " + e);
        }

        return connection;
    }
    public void Desconectar() {
        try {
            if(connection!=null){
                connection.close();
            }

        } catch (SQLException e) {
            System.out.println("Error: " + e);
        }
    }
    private void cargarConfiguracion(){
        Properties configuracion = new Properties();

        try {
            configuracion.load(new FileInputStream("configuration.props"));
            servidor = configuracion.getProperty("servidor");
            basedadatos = configuracion.getProperty("basededatos");
            puerto = configuracion.getProperty("puerto");
            driver = configuracion.getProperty("driver");
            usuario = configuracion.getProperty("usuario");
            password = configuracion.getProperty("contrasena");
        } catch (FileNotFoundException e1) {
            System.out.println("Error: " + e1);
        } catch (IOException e2) {
            System.out.println("Error: " + e2);
        }
    }

}
