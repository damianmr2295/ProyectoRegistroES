package com.iesmz.proyectofinal.dmr.service;

import com.iesmz.proyectofinal.dmr.domain.Horario;

import java.util.Set;

public interface HorarioService {

    Set<Horario> findAll();
    //Optional<Horario> findById(long id);
    Set<Horario> findByCurso(String curso);
}
