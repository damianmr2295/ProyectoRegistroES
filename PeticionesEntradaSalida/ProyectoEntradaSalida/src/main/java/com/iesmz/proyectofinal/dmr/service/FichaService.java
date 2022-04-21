package com.iesmz.proyectofinal.dmr.service;

import com.iesmz.proyectofinal.dmr.domain.Ficha;

import java.time.LocalDate;
import java.util.List;
import java.util.Optional;
import java.util.Set;

public interface FichaService {

    Set<Ficha> findAll();
    Optional<Ficha> findById(long id);
    List<Ficha> findByFecha(LocalDate fecha);
    Ficha fichaModify(long id, Ficha newFicha);
}
