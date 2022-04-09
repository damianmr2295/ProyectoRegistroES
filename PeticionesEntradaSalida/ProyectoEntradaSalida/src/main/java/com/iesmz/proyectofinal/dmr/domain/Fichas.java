package com.iesmz.proyectofinal.dmr.domain;

import io.swagger.v3.oas.annotations.media.Schema;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.persistence.*;
import java.time.LocalDate;

@Data
@AllArgsConstructor
@NoArgsConstructor
@Entity(name = "fichas")
public class Fichas {

    @Schema(description = "id de los fichajes", example = "1", required = true)
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private long idFichas;

    @Schema(description = "Fecha en la que se realiza el fichaje", example = "12/10/2021",
            required = true)
    @Column
    private LocalDate fecha;

    @Schema(description = "Información si se ha fichado en esa hora", example = "True",
            required = true)
    @Column
    private boolean fichado;

    @OneToOne(cascade = {CascadeType.ALL})
    @JoinColumn(name="idHorario")
    private Horario horario;
}
