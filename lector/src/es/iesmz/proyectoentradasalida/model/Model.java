package es.iesmz.proyectoentradasalida.model; //EJERCICIO 1.2.4

import es.iesmz.proyectoentradasalida.Aula;
import es.iesmz.proyectoentradasalida.Departamento;
import es.iesmz.proyectoentradasalida.Horario;
import es.iesmz.proyectoentradasalida.Profesor;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

public class Model {

    ConnectionDb conexion = null;

    public Model() {
        conexion = new ConnectionDb();
    }

    public int buscarIdUser(String dni){
        int idUser = 0;
        PreparedStatement pst = null;
        ResultSet rs = null;

        try {
            String sql = "SELECT id_user FROM user WHERE dni LIKE ?";

            pst = conexion.Conectar().prepareStatement(sql);
            pst.setString(1, dni);
            rs = pst.executeQuery();

            while(rs.next()) {
                idUser = rs.getInt("id_user");
            }

            rs.close();
            pst.close();
        } catch (SQLException sql) {
            sql.printStackTrace();
        }

        return idUser;
    }
    public int buscarIdAula(String nombre){
        int idAula = 0;
        PreparedStatement pst = null;
        ResultSet rs = null;

        try {
            String sql = "SELECT id_aula FROM aula WHERE nombre LIKE ?";

            pst = conexion.Conectar().prepareStatement(sql);
            pst.setString(1, nombre);
            rs = pst.executeQuery();

            while(rs.next()) {
                idAula = rs.getInt("id_aula");
            }

            rs.close();
            pst.close();
        } catch (SQLException sql) {
            sql.printStackTrace();
        }

        return idAula;
    }
    public int buscarIdDepartamento(String nombre){
        int idDepartamento = 0;
        PreparedStatement pst = null;
        ResultSet rs = null;

        try {
            String sql = "SELECT id_departamento FROM departamento WHERE nombre LIKE ?";

            pst = conexion.Conectar().prepareStatement(sql);
            pst.setString(1, nombre);
            rs = pst.executeQuery();

            while(rs.next()) {
                idDepartamento = rs.getInt("id_departamento");
            }

            rs.close();
            pst.close();
        } catch (SQLException sql) {
            sql.printStackTrace();
        }

        return idDepartamento;
    }
    public List<Integer> buscarIdHorario(){
        List<Integer> idDepartamento = new ArrayList<>();
        PreparedStatement pst = null;
        ResultSet rs = null;

        try {
            String sql = "SELECT id_horario FROM horario ";

            pst = conexion.Conectar().prepareStatement(sql);
            rs = pst.executeQuery();

            while(rs.next()) {
                idDepartamento.add(rs.getInt("id_horario"));
            }

            rs.close();
            pst.close();
        } catch (SQLException sql) {
            sql.printStackTrace();
        }

        return idDepartamento;
    }

    public int insertAula(Aula aula ) {
        PreparedStatement pst;
        int state =-1;

        try {
          conexion.Conectar();

          if (conexion!=null) {

              String sql = "INSERT INTO aula (nombre) VALUES (?);";
              pst = conexion.Conectar().prepareStatement(sql);
              pst.setString(1,aula.getNombre());
              state = pst.executeUpdate();
          }
          else {
              state = -2;
          }
        } catch (SQLException sqle) {
            sqle.printStackTrace();
            try {
                conexion.Conectar().rollback();
            } catch (SQLException e) {
                e.printStackTrace();
            }
        } finally {
            if ( conexion!=null ) conexion.Desconectar();
        }
        return state;
    }
    public int insertDepart(Departamento depart ) {
        PreparedStatement pst;
        int state =-1;

        try {
            conexion.Conectar();

            if (conexion!=null) {

                String sql = "INSERT INTO departamento (nombre) VALUES (?);";
                pst = conexion.Conectar().prepareStatement(sql);
                pst.setString(1,depart.getNombre());
                state = pst.executeUpdate();
            }
            else {
                state = -2;
            }
        } catch (SQLException sqle) {
            sqle.printStackTrace();
            try {
                conexion.Conectar().rollback();
            } catch (SQLException e) {
                e.printStackTrace();
            }
        } finally {
            if ( conexion!=null ) conexion.Desconectar();
        }
        return state;
    }

    public int insertProfesor(Profesor prof ) {

        PreparedStatement pst;
        int state =-1;
        int id = 0;
        if(!prof.getDepartamento().isEmpty()) {
            id = this.buscarIdDepartamento(prof.getDepartamento());
        }
        try {
            conexion.Conectar();

            if (conexion!=null) {

                String sql = "INSERT INTO user (apellidos,dni,nombre,password,id_departamento) VALUES (?,?,?,?,?);";
                pst = conexion.Conectar().prepareStatement(sql);
                pst.setString(1,prof.getApellidos());
                pst.setString(2,prof.getDni());
                pst.setString(3,prof.getNombre());
                pst.setString(4,prof.getPassword());
                pst.setInt(5, id);

                state = pst.executeUpdate();
            }
            else {
                state = -2;
            }
        } catch (SQLException sqle) {
            sqle.printStackTrace();
            try {
                conexion.Conectar().rollback();
            } catch (SQLException e) {
                e.printStackTrace();
            }
        } finally {
            if ( conexion!=null ) conexion.Desconectar();
        }
        return state;
    }
    public int insertHorario(Horario horario) {

        PreparedStatement pst;
        int state =-1;
        int idUser = 0;
        int idAula= 0;
        if(!horario.getUser().isEmpty()) {
            idUser = this.buscarIdUser(horario.getUser());
        }
        if(!horario.getAula().isEmpty()) {
            idAula = this.buscarIdAula(horario.getAula());
        }
        try {
            conexion.Conectar();

            if (conexion!=null) {

                String sql = "INSERT INTO horario (curso,dia_semana,hora_fin,hora_inicio,id_aula,id_user) VALUES (?,?,?,?,?,?);";
                pst = conexion.Conectar().prepareStatement(sql);
                pst.setString(1,horario.getCurso());
                pst.setInt(2,Integer.parseInt(horario.getDiaSemana()));
                pst.setString(3,horario.getHoraFin());
                pst.setString(4,horario.getHoraIni());
                pst.setInt(5, idAula);
                pst.setInt(6, idUser);

                state = pst.executeUpdate();
            }
            else {
                state = -2;
            }
        } catch (SQLException sqle) {
            sqle.printStackTrace();
            try {
                conexion.Conectar().rollback();
            } catch (SQLException e) {
                e.printStackTrace();
            }
        } finally {
            if ( conexion!=null ) conexion.Desconectar();
        }
        return state;
    }
}
