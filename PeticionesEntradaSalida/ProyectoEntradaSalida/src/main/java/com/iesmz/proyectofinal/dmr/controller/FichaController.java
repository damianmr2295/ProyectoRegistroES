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
import java.util.Optional;
import java.util.Set;

@RestController
public class FichaController {
    @Autowired
    private FichaService fichaService;

    @Operation(summary = "Obtiene todas las fichas")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Existe los numescalas del vuelo", content = @Content(schema = @Schema(implementation =
                    Ficha.class))),
            @ApiResponse(responseCode = "404", description = "El vuelo no existe", content = @Content(schema = @Schema(implementation =
                    Response.class)))
    })
    @GetMapping( value = "/ficha/", produces = "application/json")
    public ResponseEntity<Set<Ficha>> getAllFicha() {
        Set<Ficha> ficha=null;
        ficha = fichaService.findAll();
        return new ResponseEntity<>(ficha, HttpStatus.OK);
    }
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

    @Operation(summary="Obtiene una ficha por su el id del horario")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "600", description = "La ficha existe",
                    content = @Content(schema = @Schema(implementation =
                            Ficha.class))),
            @ApiResponse(responseCode = "604", description = "La ficha no existe",
                    content = @Content(schema = @Schema(implementation =
                            Ficha.class)))
    })
    @GetMapping( value = "/ficha/idHorario/{id}", produces = "application/json")
    public ResponseEntity<Ficha> getFichaIdHorario(@PathVariable long id) {

        Ficha ficha = fichaService.findByIdHorario(id);

        return new ResponseEntity<Ficha>(ficha, HttpStatus.OK);
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
