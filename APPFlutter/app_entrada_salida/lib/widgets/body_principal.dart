import 'dart:ui';
import 'package:app_entrada_salida/models/ficha.dart';
import 'package:app_entrada_salida/providers/horario_providers.dart';
import 'package:app_entrada_salida/widgets/top_card.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

import 'single_card.dart';

class bodyPrincipal extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
      child: Column(children: [CardTable()]),
    );
  }
}

class CardTable extends StatelessWidget {
  final fichasProvider = proyectoProvider();
  var text; 

  @override
  Widget build(BuildContext context) {
    return Table(children: const [
      TableRow(children: [
        TopCard(
          color: Colors.blue,
          icon: Icons.wifi_tethering,
          text: '  Última conexión',
        ),
      ]),
      TableRow(children: [
        SingleCard(
          text: 'Estado',
        ),
      ]),
      TableRow(children: [
        TopCard(
          color: Colors.pinkAccent,
          icon: Icons.access_alarm_rounded,
          text: '  Notificaciónes',
        ),
      ]),
      TableRow(children: [
        SingleCard(
          text: 'Estado',
        ),
      ]),
      TableRow(children: [
        TopCard(
            color: Colors.purple, 
            icon: Icons.table_chart_outlined, 
            text: '  Horario'
          ),
      ]),
      TableRow(children: [
        SingleCard(
          text: 'Estado',
        ),
      ]),
    ]);
  }
}



String ultimaConexion(List<Ficha> listaFichas){
  int index = 0;
  bool ultConex = false; 
  do {
      if (listaFichas[index].getFichado() == true) {
        ultConex = true;        
      }
  } while (ultConex == true);

  return "";
}