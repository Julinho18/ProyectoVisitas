function pruebaPuntoNetStatic() {
    DotNet.invokeMethodAsync("SistemaDeVisitas.Client", "ObtenerCurrentCount")
        .then(resultado => {
            console.log("Conteo desde javascript" + resultado);
        });
}