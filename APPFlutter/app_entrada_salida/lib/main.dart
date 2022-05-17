import 'package:app_entrada_salida/pages/principal_page.dart';
import 'package:flutter/material.dart';

void main() => runApp(MyApp());

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
        debugShowCheckedModeBanner: false,
        title: 'AppEntradaSalida',
        initialRoute: 'principal_page',
        routes: {
          'principal_page': (BuildContext context) => principalPage(),
        });
  }
}