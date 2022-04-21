package com.iesmz.proyectofinal.dmr.controller;

import com.iesmz.proyectofinal.dmr.domain.Ficha;
import com.iesmz.proyectofinal.dmr.exception.FichaNotFoundException;
import com.iesmz.proyectofinal.dmr.service.FichaService;
import io.swagger.v3.oas.annotations.Operation;
import io.swagger.v3.oas.annotations.media.Content;
import io.swagger.v3.oas.annotations.media.Schema;
import io.swagger.v3.oas.annotations.responses.ApiResponse;
import io.swagger.v3.oas.annotations.responses.ApiResponses;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.format.annotation.DateTimeFormat;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.servlet.config.annotation.EnableWebMvc;

import java.time.LocalDate;
import java.util.List;

@RestController
public class FichaController {
    @Autowired
    private FichaService fichaService;

    @Operation(summary="Obtiene una ficha por su id")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "600", description = "La ficha existe",
                    content = @Content(schema = @Schema(implementation =
                            Ficha.class))),
            @ApiResponse(responseCode = "604", description = "La ficha no existe",
                    content = @Content(schema = @Schema(implementation =
                            Ficha.class)))
    })
    @GetMapping( value = "/ficha/id/{id}", produces = "application/json")
    public ResponseEntity<Ficha> getFicha(@PathVariable long id) {

        Ficha ficha = fichaService.findById(id)
                .orElseThrow(() -> new FichaNotFoundException(id));

        return new ResponseEntity<Ficha>(ficha, HttpStatus.OK);
    }
    @Operation(summary="Obtiene las fichas por la fecha")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "600", description = "El horario tiene fichas",
                    content = @Content(schema = @Schema(implementation =
                            Ficha.class))),
            @ApiResponse(responseCode = "604", description = "El horario no tiene fichas",
                    content = @Content(schema = @Schema(implementation =
                            Ficha.class)))
    })
    @GetMapping( value = "/ficha/fecha/{fecha}", produces = "application/json")
    public ResponseEntity<List<Ficha>> getFichasHorario(@RequestParam("localDate")
                                                      @DateTimeFormat(iso=DateTimeFormat.ISO.DATE)
                                                              LocalDate fecha) {
        List<Ficha> fichas = null;
        fichas = fichaService.findByFecha(fecha);
        return new ResponseEntity<>(fichas, HttpStatus.OK);
    }
    @Operation(summary = "Modifica una ficha")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Se modifica la ficha",
                    content = @Content(schema = @Schema(implementation =
                            Ficha.class))),
            @ApiResponse(responseCode = "404", description = "La ficha no existe",
                    content = @Content(schema = @Schema(implementation =
                            Response.class)))
    })
    @PutMapping(value = "/ficha/modificar/{id}", produces = "application/json", consumes = "application/json")
    public ResponseEntity<Ficha> fichaModify(@PathVariable long id,
                                                   @RequestBody Ficha newFicha) {
        Ficha ficha = fichaService.fichaModify(id, newFicha);
        return new ResponseEntity<>(ficha, HttpStatus.OK);
    }
}
