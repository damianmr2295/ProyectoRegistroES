package com.iesmz.proyectofinal.dmr.service;

import com.iesmz.proyectofinal.dmr.domain.Horario;

import java.util.List;
import java.util.Optional;
import java.util.Set;

public interface HorarioService {

    Set<Horario> findAll();
    Optional<Horario> findById(long id);
    List<Horario> findByDiaSemana(int id);

}
