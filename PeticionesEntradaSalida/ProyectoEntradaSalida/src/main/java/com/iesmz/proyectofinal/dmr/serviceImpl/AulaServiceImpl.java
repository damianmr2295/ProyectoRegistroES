package com.iesmz.proyectofinal.dmr.serviceImpl;

import com.iesmz.proyectofinal.dmr.domain.Aula;
import com.iesmz.proyectofinal.dmr.repository.AulaRepository;
import com.iesmz.proyectofinal.dmr.service.AulaService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import javax.transaction.Transactional;
import java.util.Optional;
import java.util.Set;

@Service
@Transactional
public class AulaServiceImpl implements AulaService {

    @Autowired
    private AulaRepository aulaRepository;

    @Override
    public Set<Aula> findAll() {
        return aulaRepository.findAll();
    }
    @Override
    public Optional<Aula> findById(long id) {
        return aulaRepository.findById(id);
    }
    @Override
    public Set<Aula> findByNombre(String nombre) {
        return aulaRepository.findByNombre(nombre);
    }
}
