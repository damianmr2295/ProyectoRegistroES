package com.iesmz.proyectofinal.dmr.serviceImpl;

import com.iesmz.proyectofinal.dmr.domain.Departamento;
import com.iesmz.proyectofinal.dmr.repository.DepartamentoRepository;
import com.iesmz.proyectofinal.dmr.service.DepartamentoService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import javax.transaction.Transactional;
import java.util.Optional;
import java.util.Set;

@Service
@Transactional
public class DepartamentoServiceImpl implements DepartamentoService {

    @Autowired
    private DepartamentoRepository departamentoRepository;

    @Override
    public Set<Departamento> findAll() {
        return departamentoRepository.findAll();
    }
    @Override
    public Optional<Departamento> findById(long id) {
        return departamentoRepository.findById(id);
    }
    @Override
    public Set<Departamento> findByNombre(String nombre) {
        return departamentoRepository.findByNombre(nombre);
    }
}
