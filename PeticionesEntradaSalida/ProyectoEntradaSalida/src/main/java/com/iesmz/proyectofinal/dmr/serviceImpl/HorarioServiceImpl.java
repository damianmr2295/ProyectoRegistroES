package com.iesmz.proyectofinal.dmr.serviceImpl;

import com.iesmz.proyectofinal.dmr.domain.Horario;
import com.iesmz.proyectofinal.dmr.repository.HorarioRepository;
import com.iesmz.proyectofinal.dmr.service.HorarioService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import javax.transaction.Transactional;
import java.util.List;
import java.util.Optional;
import java.util.Set;

@Service
@Transactional
public class HorarioServiceImpl implements HorarioService {

    @Autowired
    private HorarioRepository horarioRepository;
    @Override
    public Set<Horario> findAll() {
        return horarioRepository.findAll();
    }

    @Override
    public Optional<Horario> findById(long id) {
        return horarioRepository.findById(id);
    }

    @Override
    public List<Horario> findByDiaSemana(int diaSemana) {
        return horarioRepository.findByDiaSemana(diaSemana);
    }
}
