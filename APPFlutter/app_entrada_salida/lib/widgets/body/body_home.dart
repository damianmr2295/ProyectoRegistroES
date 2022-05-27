import 'dart:ui';
import 'package:app_entrada_salida/models/ficha.dart';
import 'package:app_entrada_salida/pages/horario_page.dart';
import 'package:app_entrada_salida/widgets/card/horario_card.dart';
import 'package:app_entrada_salida/widgets/card/single_card.dart';
import 'package:app_entrada_salida/widgets/card/top_card.dart';
import 'package:intl/intl.dart';
import 'package:app_entrada_salida/providers/proyecto_providers.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class bodyHome extends StatefulWidget {
  String? usuario;
  String? dni;
  bodyHome(this.usuario, this.dni);
  @override
  State<bodyHome> createState() {
    return bodyFicharPageState(usuario, dni);
  }
}

class bodyFicharPageState extends State<bodyHome> {
  String? usuario;
  String? dni;
  bodyFicharPageState(this.usuario, this.dni);
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: ListView(
        padding: const EdgeInsets.symmetric(horizontal: 10, vertical: 2),
        children: [
          const Divider(),
          Column(
            children: [
              const Divider(),
              crearBody(),
            ],
          ),
          const Divider(),
        ],
      ),
    );
  }

  Widget crearBody() {
    final fichasProvider = proyectoProvider();
    Future<List<Ficha>> fichas = fichasProvider.getinfoFichar();
    return FutureBuilder(
        future: fichas,
        builder: (BuildContext context, AsyncSnapshot<List> snapshot) {
          if (snapshot.hasData) {
            return tarjetaFicha(snapshot.data!);
          } else {
            return const Center(
              child: CircularProgressIndicator(),
            );
          }
        });
  }

  Widget tarjetaFicha(List<dynamic> fichas) {
    String ultConex = ultimaDiaFichado(fichas, dni);
    String fichado = hasFichado(fichas, dni);
    return Column(
      children: [
        ListView.builder(
            physics: const NeverScrollableScrollPhysics(),
            shrinkWrap: true,
            itemCount: 3,
            itemBuilder: (BuildContext context, int index) {
              if (index == 0) {
                return ultimaConexion(ultConex);
              } else if (index == 1) {
                return notificaciones(fichado);
              } else {
                return horario();
              }
            }),
      ],
    );
  }

  Container ultimaConexion(String ultConex) {
    return Container(
      padding: const EdgeInsets.fromLTRB(10, 10, 10, 0),
      height: 180,
      child: Card(
        child: GestureDetector(
        child: Table(children: [
          const TableRow(
            children: [
              TopCard(
                color: Colors.blue,
                icon: Icons.wifi_tethering,
                text: '  Ultima conexión',
              ),
            ],
          ),
          TableRow(
            children: [
              SingleCard(
                text: ultConex,
              ),
            ],
          ),
        ]),
      )),
    );
  }

  Container notificaciones(String notificacion) {
    return Container(
      padding: const EdgeInsets.fromLTRB(10, 10, 10, 0),
      height: 180,
      child: Card(
        child: GestureDetector(
          child: Table(children: [
            const TableRow(
              children: [
                TopCard(
                  color: Colors.blue,
                  icon: Icons.message,
                  text: '  Notificaciones',
                ),
              ],
            ),
            TableRow(
              children: [
                SingleCard(
                  text: notificacion,
                ),
              ],
            ),
          ]),
        )
      ),
    );
  }

  Container horario() {
    return Container(
      padding: const EdgeInsets.fromLTRB(10, 10, 10, 0),
      height: 180,
      child: Card(
        child: GestureDetector(
          onTap:() {
              Navigator.of(context).pushAndRemoveUntil(MaterialPageRoute<Null>(
                builder: (BuildContext context){
                  return new HorarioPage(usuario, DateTime.now(), dni);
                }  
            ),(Route<dynamic> route) => false

          );
          },
          child: Table(children: const [
            TableRow(
              children: [
                TopCard(
                  color: Colors.blue,
                  icon: Icons.calendar_view_month_rounded,
                  text: '  Horario',
                ),
              ],
            ),
            TableRow(
              children: [
                Horario(
                  text: "Tu horario semanal",
                ),
              ],
            ),
          ]),
      )),
    );
  }
}

DateTime devolverFecha(DateTime fecha) {
  DateTime fechaRestada = fecha.add(const Duration(days: 1));
  return fechaRestada;
}

String ultimaDiaFichado(List<dynamic> fichas, String? dni) {
  String conexion = "No hay conexión";
  DateTime dia = DateTime.now().subtract(const Duration(days: 8));
  String diaSemana;
  int index = 0;
  do {

    dia = devolverFecha(dia);
    diaSemana = DateFormat('yyyy-MM-dd').format(dia);
      for (int i = 0; i < fichas.length; i++) {
        print("ESTAMOS EN EL FOR $diaSemana");

        if ((diaSemana == fichas[i].getFecha()) &&
            (fichas[i].getFichado() == true) && dni == fichas[i].getHorario().getUser()) {
          conexion = fichas[i].getFecha();
        }
      }
    index++;
  } while (index < fichas.length);

  return conexion;
}

String hasFichado(List<dynamic> fichas, String? dni) {
  String fichado = "Hoy no has fichado";
  String diaSemana = DateFormat('yyyy-MM-dd').format(DateTime.now());
  int index = 0;
  do {
    for (int i = 0; i < fichas.length; i++) {
      if ((diaSemana == fichas[i].getFecha()) &&
          (fichas[i].getFichado() == true && dni == fichas[i].getHorario().getUser())) {
        fichado = "Has fichado";
      }
    }
    index++;
  } while (index < fichas.length);

  return fichado;
}