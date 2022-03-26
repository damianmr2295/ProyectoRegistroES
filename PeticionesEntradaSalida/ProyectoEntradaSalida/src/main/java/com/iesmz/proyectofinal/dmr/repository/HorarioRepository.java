package com.iesmz.proyectofinal.dmr.repository;

import com.iesmz.proyectofinal.dmr.domain.Horario;
import org.springframework.data.repository.CrudRepository;

import java.util.Set;

public interface HorarioRepository extends CrudRepository<Horario, Long> {
    Set<Horario> findAll();

}
