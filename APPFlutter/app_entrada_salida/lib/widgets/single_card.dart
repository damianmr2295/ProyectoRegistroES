import 'dart:ui';

import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class SingleCard extends StatelessWidget {
  final String text;
  const SingleCard(
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
        borderRadius: BorderRadius.circular(20));
    return Container(
        margin: const EdgeInsets.only(left: 20.0, right: 20.0),
        child: ClipRRect(
          borderRadius: BorderRadius.circular(20),
          child: BackdropFilter(
            filter: ImageFilter.blur(sigmaX: 5, sigmaY: 5),
            child: Container(
              height: 80,
              decoration: boxDecoration,
              child: child,
            ),
          ),
        ));
  }
}