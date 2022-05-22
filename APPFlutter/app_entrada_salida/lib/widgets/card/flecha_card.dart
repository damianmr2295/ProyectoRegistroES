import 'dart:ui';

import 'package:app_entrada_salida/pages/horario_page.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class FlechaCard extends StatelessWidget {
  final Color color;
  final String fecha;
  final String usuario;
  final String dni;
  const FlechaCard(
      {Key? key,
      required this.color,
      required this.fecha,
      required this.usuario,
      required this.dni})
      : super(key: key);
  @override
  Widget build(BuildContext context) {
    DateTime fechaDate = DateTime.parse(fecha);
    var column = Column(
      mainAxisAlignment: MainAxisAlignment.center,
      children: [
        Row(
          children: [
            CircleAvatar(
              backgroundColor: color,
              child: GestureDetector(
                onTap: () {
                  fechaDate = fechaDate.subtract(const Duration(days: 1));
                  Navigator.of(context).pushAndRemoveUntil(
                      MaterialPageRoute<Null>(builder: (BuildContext context) {
                    return new HorarioPage(usuario, fechaDate, dni);
                  }), (Route<dynamic> route) => false);
                },
                child: const Icon(
                  Icons.arrow_back,
                  size: 35,
                ),
              ),
              radius: 25,
            ),
            Text(
              "         " + fecha + "        ",
              style: TextStyle(color: color, fontSize: 25),
            ),
            CircleAvatar(
              backgroundColor: color,
              child: GestureDetector(
                onTap: () {
                  fechaDate = fechaDate.add(const Duration(days: 1));
                  Navigator.of(context).pushAndRemoveUntil(
                      MaterialPageRoute<Null>(builder: (BuildContext context) {
                    return new HorarioPage(usuario, fechaDate, dni);
                  }), (Route<dynamic> route) => false);
                },
              child: const Icon(
                Icons.arrow_forward,
                size: 35,
              ),
              ),
              radius: 25,
            ),
            const SizedBox(height: 25),
          ],
        ),
      ],
    );
    return _CardBackground(child: column);
  }
}

class _CardBackground extends StatelessWidget {
  final Widget child;
  const _CardBackground({Key? key, required this.child}) : super(key: key);
  @override
  Widget build(BuildContext context) {
    return Container(
        margin: const EdgeInsets.all(10),
        child: ClipRRect(
          borderRadius: BorderRadius.circular(20),
          child: BackdropFilter(
            filter: ImageFilter.blur(sigmaX: 25, sigmaY: 25),
            child: SizedBox(
              height: 50,
              child: child,
            ),
          ),
        ));
  }
}
