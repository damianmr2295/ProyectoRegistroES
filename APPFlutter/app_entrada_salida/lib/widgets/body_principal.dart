import 'dart:ui';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class bodyPrincipal extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
      child: Column(children: [
        CardTable()
      ]),
    );
  }
}
class CardTable extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Table(children: const [
      TableRow(children: [
        _SingleCard(
          color: Colors.blue,
          icon: Icons.border_all,
          text: 'Estado',
        ),]),
      TableRow(children: [
        _SingleCard(
          color: Colors.pinkAccent,
          icon: Icons.car_rental,
          text: 'Notificaciónes',
        ),
      ]),
      TableRow(children: [
        _SingleCard(
          color: Colors.purple,
          icon: Icons.border_all,
          text: 'Horario'),]),
      TableRow(children: [
        _SingleCard(
            color: Colors.purpleAccent,
            icon: Icons.cloud,
            text: 'Historial de fichajes'),
      ]),
    ]);
  }
}

class _SingleCard extends StatelessWidget {
  final IconData icon;
  final Color color;
  final String text;
  const _SingleCard(
      {Key? key, required this.icon, required this.color, required this.text})
      : super(key: key);
  @override
  Widget build(BuildContext context) {
    var column = Column(
      mainAxisAlignment: MainAxisAlignment.center,
      children: [
        CircleAvatar(
          backgroundColor: this.color,
          child: Icon(
            this.icon,
            size: 35,
          ),
          radius: 30,
        ),
        SizedBox(height: 15),
        Text(
          this.text,
          style: TextStyle(color: this.color, fontSize: 22),
        )
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
    final boxDecoration = BoxDecoration(
        color: Color.fromRGBO(62, 66, 107, 0.7),
        borderRadius: BorderRadius.circular(20));
    return Container(
        margin: EdgeInsets.all(20),
        child: ClipRRect(
          borderRadius: BorderRadius.circular(20),
          child: BackdropFilter(
            filter: ImageFilter.blur(sigmaX: 5, sigmaY: 5),
            child: Container(
              height: 180,
              decoration: boxDecoration,
              child: this.child,
            ),
          ),
        ));
  }
}
