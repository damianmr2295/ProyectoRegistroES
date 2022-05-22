import 'dart:ui';
import 'package:app_entrada_salida/models/ficha.dart';
import 'package:app_entrada_salida/widgets/card/single_card.dart';
import 'package:app_entrada_salida/widgets/card/top_card.dart';
import 'package:intl/intl.dart';
import 'package:app_entrada_salida/providers/horario_providers.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class bodyHome extends StatefulWidget {
  String? usuario;
  bodyHome(this.usuario);
  @override
  State<bodyHome> createState() {
    return bodyFicharPageState(usuario);
  }
}

class bodyFicharPageState extends State<bodyHome> {
  String? usuario;
  bodyFicharPageState(this.usuario);
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
              crearFicha(usuario),
            ],
          ),
          const Divider(),
        ],
      ),
    );
  }

  Widget crearFicha(String? usuario) {
    final fichasProvider = proyectoProvider();
    Future<List<Ficha>> fichas = fichasProvider.getinfoFichar();
    return FutureBuilder(
        future: fichas,
        builder: (BuildContext context, AsyncSnapshot<List> snapshot) {
          if (snapshot.hasData) {
            return tarjetaFicha(snapshot.data!, usuario);
          } else {
            return const Center(
              child: CircularProgressIndicator(),
            );
          }
        });
  }

  Widget tarjetaFicha(List<dynamic> fichas, String? usuario) {
    String ultConex = ultimaDiaFichado(fichas, usuario);
    String fichado = hasFichado(fichas, usuario);
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
                icon: Icons.wifi_tethering,
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
      )),
    );
  }

  Container horario() {
    return Container(
      padding: const EdgeInsets.fromLTRB(10, 10, 10, 0),
      height: 180,
      child: Card(
          child: GestureDetector(
        child: Table(children: const [
          TableRow(
            children: [
              TopCard(
                color: Colors.blue,
                icon: Icons.wifi_tethering,
                text: '  Horario',
              ),
            ],
          ),
          TableRow(
            children: [
              SingleCard(
                text: "Horario",
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

String ultimaDiaFichado(List<dynamic> fichas, String? usuario) {
  String conexion = "No hay conexión";
  DateTime dia = DateTime.now().subtract(const Duration(days: 8));
  String diaSemana;
  int index = 0;
  do {
    dia = devolverFecha(dia);
    diaSemana = DateFormat('yyyy-MM-dd').format(dia);
      for (int i = 0; i < fichas.length; i++) {
        if ((diaSemana == fichas[i].getFecha()) &&
            (fichas[i].getFichado() == true) && usuario == fichas[i].getHorario().getUser()) {
          conexion = fichas[i].getFecha();
        }
      }
    index++;
  } while (index < fichas.length);

  return conexion;
}

String hasFichado(List<dynamic> fichas, String? usuario) {
  String fichado = "Hoy no has fichado";
  String diaSemana = DateFormat('yyyy-MM-dd').format(DateTime.now());
  int index = 0;
  do {
    for (int i = 0; i < fichas.length; i++) {
      if ((diaSemana == fichas[i].getFecha()) &&
          (fichas[i].getFichado() == true && usuario == fichas[i].getHorario().getUser())) {
        fichado = "Has fichado";
      }
    }
    index++;
  } while (index < fichas.length);

  return fichado;
}
