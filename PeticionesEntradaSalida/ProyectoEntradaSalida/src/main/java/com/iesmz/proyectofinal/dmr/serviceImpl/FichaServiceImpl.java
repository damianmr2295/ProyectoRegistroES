package com.iesmz.proyectofinal.dmr.serviceImpl;

import com.iesmz.proyectofinal.dmr.domain.Ficha;
import com.iesmz.proyectofinal.dmr.exception.FichaNotFoundException;
import com.iesmz.proyectofinal.dmr.repository.FichaRepository;
import com.iesmz.proyectofinal.dmr.service.FichaService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import javax.transaction.Transactional;
import java.time.LocalDate;
import java.util.List;
import java.util.Optional;
import java.util.Set;

@Service
@Transactional
public class FichaServiceImpl implements FichaService {

    @Autowired
    private FichaRepository fichaRepository;
    @Override
    public Set<Ficha> findAll() {
        return fichaRepository.findAll();
    }

    @Override
    public Optional<Ficha> findById(long id) {
        return fichaRepository.findById(id);
    }

    @Override
    public List<Ficha> findByFecha(LocalDate fecha) {
        return fichaRepository.findByFecha(fecha);
    }

    @Override
    public Ficha fichaModify(long id, Ficha newFicha) {
        Ficha ficha = fichaRepository.findById(id).orElseThrow(() -> new FichaNotFoundException(id));
        newFicha.setIdFicha(ficha.getIdFicha());
        return fichaRepository.save(newFicha);
    }
}
