import 'dart:ui';

import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class CerrarSesion extends StatelessWidget {
  final String text;
  const CerrarSesion(
      {Key? key,required this.text})
      : super(key: key);
  @override
  Widget build(BuildContext context) {
    var column = Column(
      mainAxisAlignment: MainAxisAlignment.center,
      children: [
        Text(
          text,
          style: const TextStyle(color: Colors.black, fontSize: 20),
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
        color: const Color.fromRGBO(25, 180, 180, 0.7),
        borderRadius: BorderRadius.circular(20)
      );
    return Container(
        child: ClipRRect(
          borderRadius: BorderRadius.circular(40),
          child: BackdropFilter(
            filter: ImageFilter.blur(sigmaX: 5, sigmaY: 5),
            child: Container(
              height: 70,
              decoration: boxDecoration,
              child: child,
            ),
          ),
        ));
  }
}