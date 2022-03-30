package com.iesmz.proyectofinal.dmr.controller;

import com.iesmz.proyectofinal.dmr.domain.Horario;
import com.iesmz.proyectofinal.dmr.service.HorarioService;
import io.swagger.v3.oas.annotations.Operation;
import io.swagger.v3.oas.annotations.media.Content;
import io.swagger.v3.oas.annotations.media.Schema;
import io.swagger.v3.oas.annotations.responses.ApiResponse;
import io.swagger.v3.oas.annotations.responses.ApiResponses;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.Set;

@RestController
public class HorarioController {

    @Autowired
    private HorarioService horarioService;

    @Operation(summary = "Obtiene todos el horario")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "600", description = "El Horario existe",
                    content = @Content(schema = @Schema(implementation =
                            Horario.class))),
            @ApiResponse(responseCode = "404", description = "El Horario no existe",
                    content = @Content(schema = @Schema(implementation =
                            Horario.class)))
    })
    @GetMapping( value = "/departamento", produces = "application/json")
    public ResponseEntity<Set<Horario>> getAllHorario() {
        Set<Horario> horario=null;
        horario = horarioService.findAll();
        return new ResponseEntity<>(horario, HttpStatus.OK);
    }
}
