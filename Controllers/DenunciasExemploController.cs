// using Microsoft.AspNetCore.Mvc;
// using System.Collections.Generic;
// using omni.Models;
// using System;
// using System.Globalization;
// using System.Linq;

// namespace tcc.Controllers
// {

//     [ApiController]
//     [Route("[Controller]")]
//     public class DenunciasExemploController : ControllerBase
//     {

//         private static List<Denuncia> denuncias = new List<Denuncia>(){
//             new Denuncia() { IdDenuncia = 1, IdCidadao = 1, IdTipoDenuncia = 1, IdStatus = 1,
//             DataDenuncia = DateTime.Parse("15/08/2000"), DescricaoDenuncia = "Testando a criação da denúncia",
//             LocalDenuncia = "São Paulo", PontosPrioridade = 1 },
//             new Denuncia() { IdDenuncia = 2, IdCidadao = 2, IdTipoDenuncia = 2, IdStatus = 1,
//             DataDenuncia = DateTime.Parse("13/08/2000"), DescricaoDenuncia = "Testando denúncia",
//             LocalDenuncia = "São Paulo", PontosPrioridade = 1 },
//             new Denuncia() { IdDenuncia = 3, IdCidadao = 1, IdTipoDenuncia = 3, IdStatus = 2,
//             DataDenuncia = DateTime.Parse("19/08/2000"), DescricaoDenuncia = "Denúncia",
//             LocalDenuncia = "São Paulo", PontosPrioridade = 1 },
//         };

//         // Métodos
//         public IActionResult GetFirst()
//         {
//             Denuncia d = denuncias[0];
//             return Ok(d);
//         }

//         [HttpGet("{id}")]
//         public IActionResult GetSingle(int id)
//         {
//             return Ok(denuncias.FirstOrDefault(de => de.IdDenuncia == id));
//         }

//         [HttpGet("GetAll")]
//         public IActionResult GetAll()
//         {
//             return Ok(denuncias);
//         }

//         [HttpPost]
//         public IActionResult AddDenuncia(Denuncia novaDenuncia)
//         {
//             denuncias.Add(novaDenuncia);
//             return Ok(denuncias);
//         }

//         [HttpPut("UpdateStatusDenuncia")]
//         public IActionResult UpdateStatusDenuncia(Denuncia d)
//         {
//             Denuncia denunciaAlterada = denuncias.Find(den => den.IdDenuncia == d.IdDenuncia);
//             denunciaAlterada.IdStatus = d.IdStatus;

//             return Ok(denuncias);
//         }

//         [HttpPut("UpdateDescricaoDenuncia")]
//         public IActionResult UpdateDescricaoDenuncia(Denuncia d)
//         {
//             Denuncia denunciaAlterada = denuncias.Find(den => den.IdDenuncia == d.IdDenuncia);
//             denunciaAlterada.DescricaoDenuncia = d.DescricaoDenuncia;

//             return Ok(denuncias);
//         }

//     }
// }