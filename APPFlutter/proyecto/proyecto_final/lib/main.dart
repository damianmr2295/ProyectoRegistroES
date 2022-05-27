import 'package:flutter/material.dart';
import 'package:proyecto_final/pages/login_page.dart';

void main() => runApp(MyApp());

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
        debugShowCheckedModeBanner: false,
        title: 'AppEntradaSalida',
        initialRoute: 'login_page',
        routes: {
          'login_page': (BuildContext context) => loginPage(),
        });
  }
}