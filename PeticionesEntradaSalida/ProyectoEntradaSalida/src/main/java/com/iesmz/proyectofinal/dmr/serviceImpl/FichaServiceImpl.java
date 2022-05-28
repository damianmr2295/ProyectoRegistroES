package com.iesmz.proyectofinal.dmr.serviceImpl;

import com.iesmz.proyectofinal.dmr.domain.Ficha;
import com.iesmz.proyectofinal.dmr.domain.Horario;
import com.iesmz.proyectofinal.dmr.exception.FichaNotFoundException;
import com.iesmz.proyectofinal.dmr.repository.FichaRepository;
import com.iesmz.proyectofinal.dmr.repository.HorarioRepository;
import com.iesmz.proyectofinal.dmr.service.FichaService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import javax.transaction.Transactional;
import java.text.SimpleDateFormat;
import java.time.LocalDate;
import java.util.Date;
import java.util.List;
import java.util.Optional;
import java.util.Set;
import java.util.logging.SimpleFormatter;

@Service
@Transactional
public class FichaServiceImpl implements FichaService {

    @Autowired
    private FichaRepository fichaRepository;
    @Autowired
    private HorarioRepository horarioRepository;
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
    public Ficha findByIdHorario(long id) {
        Set<Ficha> fichas = fichaRepository.findAll();
        Ficha fichaIdHorario = new Ficha();
        boolean noExiste = false;
        for (Ficha f:fichas) {
            if (f.getHorario().getIdHorario() == id && f.getFecha().equals(LocalDate.now())) {
                fichaIdHorario = f;
                noExiste = true;
            }
        }
        if (!noExiste) {
            Optional<Horario> horarioOpt = horarioRepository.findById(id);
            if (horarioOpt.isPresent()) {
                fichaIdHorario.setHorario(horarioOpt.get());
                fichaIdHorario.setFichado(false);
                fichaIdHorario.setFecha(LocalDate.now());
                fichaRepository.save(fichaIdHorario);
            }
        }
        return fichaIdHorario;
    }

    @Override
    public Ficha fichaModify(long id, Ficha newFicha) {
        Ficha ficha = fichaRepository.findById(id).orElseThrow(() -> new FichaNotFoundException(id));
        newFicha.setIdFicha(ficha.getIdFicha());
        return fichaRepository.save(newFicha);
    }
}
