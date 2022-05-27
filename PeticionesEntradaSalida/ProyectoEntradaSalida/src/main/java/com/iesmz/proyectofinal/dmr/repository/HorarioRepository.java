package com.iesmz.proyectofinal.dmr.repository;

import com.iesmz.proyectofinal.dmr.domain.Horario;
import org.springframework.data.repository.CrudRepository;

import java.util.List;
import java.util.Optional;
import java.util.Set;

public interface HorarioRepository extends CrudRepository<Horario, Long> {
    Set<Horario> findAll();
    Optional<Horario> findById(long id);
    List<Horario> findByDiaSemana(int id);
}
