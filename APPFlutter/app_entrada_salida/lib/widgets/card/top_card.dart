import 'dart:ui';

import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class TopCard extends StatelessWidget {
  final IconData icon;
  final Color color;
  final String text;
  const TopCard(
      {Key? key, required this.icon, required this.color, required this.text})
      : super(key: key);
  @override
  Widget build(BuildContext context) {
    var column = Column(
      mainAxisAlignment: MainAxisAlignment.center,
      children: [
        Row(
          children: [
            CircleAvatar(
              backgroundColor: color,
              child: Icon(
                icon,
                size: 20,
              ),
              radius: 20,
            ),
            const SizedBox(height: 10),
            Text(
              text,
              style: TextStyle(color: color, fontSize: 25),
            )
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