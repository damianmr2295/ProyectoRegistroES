package com.iesmz.proyectofinal.dmr.repository;

import com.iesmz.proyectofinal.dmr.domain.Ficha;
import org.springframework.data.repository.CrudRepository;

import java.time.LocalDate;
import java.util.List;
import java.util.Optional;
import java.util.Set;

public interface FichaRepository extends CrudRepository<Ficha, Long> {
    Set<Ficha> findAll();
    Optional<Ficha> findById(long id);
    List<Ficha> findByFecha(LocalDate fecha);
}
