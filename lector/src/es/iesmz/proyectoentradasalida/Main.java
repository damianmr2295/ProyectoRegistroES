package es.iesmz.proyectoentradasalida;

import es.iesmz.proyectoentradasalida.model.Model;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;
import java.io.File;
import java.util.*;

public class Main {

    public static void main(String[] args) {
        Model modelo = new Model();

        List<Departamento> listaDepartamentos = new ArrayList<>();
        List<Profesor> listaProfesores = new ArrayList<>();
        List<Aula> listaAulas = new ArrayList<>();
        List<Horario> listaHorarios = new ArrayList<>();
        List<String> listaGrupo = new ArrayList<>();
        int index = 0;


        //PROFESORES Y DEPARTAMENTOS
        try {
            DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();
            factory.setNamespaceAware(true);

            DocumentBuilder builder = factory.newDocumentBuilder();
            Document documento = builder.parse(new File("Horario_COLOMA.xml"));

            NodeList profesores = documento.getElementsByTagName("profesor");

            for(int i=0; i < profesores.getLength(); i++){
                Profesor profesor = new Profesor();
                String datos ;

                Node profe = profesores.item(i);
                Element elemento = (Element) profe;

                datos = elemento.getElementsByTagName("nombreCompleto").item(0).getTextContent();

                String[] nombreSeparado = datos.split(",");
                if(nombreSeparado.length > 1) {
                    profesor.setNombre(nombreSeparado[1]);
                }
                if (nombreSeparado.length != 0) {
                    profesor.setApellidos(nombreSeparado[0]);
                }
                datos = null;
                datos = elemento.getElementsByTagName("departamento").item(0).getTextContent();
                if ( !Objects.isNull(datos) && !datos.isEmpty()) {
                    profesor.setDepartamento(datos);
                }
                datos = null;
                datos = elemento.getElementsByTagName("nombre").item(0).getTextContent();
                if ( !Objects.isNull(datos) && !datos.isEmpty()) {
                    profesor.setDni(datos);
                }
                profesor.setPassword("marcosz");
                listaProfesores.add(profesor);
            }
        } catch (ParserConfigurationException e) {
            e.printStackTrace();
        } catch (Exception e) {
            e.printStackTrace();
        }

        for ( Profesor p : listaProfesores) {
            Departamento departamento = new Departamento();
            departamento.setNombre(p.getDepartamento());
            listaDepartamentos.add(departamento);
        }
        Set<Departamento> hashSet = new HashSet<Departamento>(listaDepartamentos);
        listaDepartamentos.clear();
        listaDepartamentos.addAll(hashSet);

        //AULAS
        try {
            DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();
            factory.setNamespaceAware(true);

            DocumentBuilder builder = factory.newDocumentBuilder();
            Document documento = builder.parse(new File("Horario_COLOMA.xml"));

            NodeList aulas = documento.getElementsByTagName("aula");

            for(int i=0; i < aulas.getLength(); i++){
                Aula aula = new Aula();
                String nombreAula ;

                Node profe = aulas.item(i);
                Element elemento = (Element) profe;


                nombreAula = elemento.getElementsByTagName("nombre").item(0).getTextContent();
                if ( !Objects.isNull(nombreAula) && !nombreAula.isEmpty()) {
                    aula.setNombre(nombreAula);
                }
                listaAulas.add(aula);
            }
        } catch (ParserConfigurationException e) {
            e.printStackTrace();
        } catch (Exception e) {
            e.printStackTrace();
        }


        /**
         * HORARIO
         * marcoHorario: dia, indice(id) y horas
         * Sesionlectivas: grupo -> nombre y aula
         * Tramo: usuario
         **/

        //CURSOS
        try {
            DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();
            factory.setNamespaceAware(true);

            DocumentBuilder builder = factory.newDocumentBuilder();
            Document documento = builder.parse(new File("Horario_COLOMA.xml"));

            NodeList marcoHorario = documento.getElementsByTagName("grupo");
            for(int i=0; i < marcoHorario.getLength(); i++){
                String nombre ;


                Node tramo = marcoHorario.item(i);
                Element elemento = (Element) tramo;

                nombre = elemento.getElementsByTagName("nombre").item(0).getTextContent();
                if ( !Objects.isNull(nombre) && !nombre.isEmpty()) {
                    listaGrupo.add(nombre);
                }
            }
        } catch (ParserConfigurationException e) {
            e.printStackTrace();
        } catch (Exception e) {
            e.printStackTrace();
        }

        Set<String> hashString = new HashSet<String>(listaGrupo);
        listaGrupo.clear();
        listaGrupo.addAll(hashString);
        try {
            DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();
            factory.setNamespaceAware(true);

            DocumentBuilder builder = factory.newDocumentBuilder();
            Document documento = builder.parse(new File("Horario_COLOMA.xml"));

            NodeList marcoHorario = documento.getElementsByTagName("tramo");
            for(int i=0; i < marcoHorario.getLength(); i++){
                Horario horario = new Horario();
                String diaSemana ;
                String horaIni;
                String horaFin;

                Node tramo = marcoHorario.item(i);
                Element elemento = (Element) tramo;

                diaSemana = elemento.getElementsByTagName("dia").item(0).getTextContent();
                if ( !Objects.isNull(diaSemana) && !diaSemana.isEmpty()) {
                    int dia = Integer.parseInt(diaSemana);
                    dia += 1;
                    horario.setDiaSemana(String.valueOf(dia));
                }
                horaIni = elemento.getElementsByTagName("horaEntrada").item(0).getTextContent();
                if ( !Objects.isNull(horaIni) && !horaIni.isEmpty()) {
                    horario.setHoraIni(horaIni);
                }
                horaFin = elemento.getElementsByTagName("horaSalida").item(0).getTextContent();
                if ( !Objects.isNull(horaFin) && !horaFin.isEmpty()) {
                    horario.setHoraFin(horaFin);
                }

                listaHorarios.add(horario);
            }
        } catch (ParserConfigurationException e) {
            e.printStackTrace();
        } catch (Exception e) {
            e.printStackTrace();
        }
        for (Horario h: listaHorarios) {
            h.setAula(listaAulas.get(index).getNombre());
            h.setUser(listaProfesores.get(index).getDni());
            h.setCurso(listaGrupo.get(index));
            index++;
            if(listaAulas.size() == index || listaProfesores.size() == index ||
                    listaGrupo.size() == index ){index = 0;}
        }

        // INSERTS A LA BBDD
        for (Departamento d:listaDepartamentos) {
            modelo.insertDepart(d);
        }
        for (Profesor p : listaProfesores) {
            modelo.insertProfesor(p);
        }
        for (Aula a : listaAulas) {
            modelo.insertAula(a);
        }
        for (Horario h : listaHorarios) {
            modelo.insertHorario(h);
        }

    }
}
