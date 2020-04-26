using MvcAzure.Models;
protected override void Seed(Bitcoin_TCC.Models.MvcAzureContext context)
{
    context.ContatoKB.AddOrUpdate(
        m => m.Nome,
            new ContatoKB { Nome = "Felipe", Email = "Ortopedista", mensagem = "0101" },
            new ContatoKB { Nome = "Waldemar", Email = "Ortopedista", mensagem = "0102" },
            new ContatoKB { Nome = "Marcos", Email = "Otorrinolaringologista", mensagem = "0201" },
            new ContatoKB { Nome = "Luiz Dario", Email = "Dematologista", mensagem = "0301" },
            new ContatoKB { Nome = "Patricia", Email = "Pediatra", mensagem = "0404" },
            new ContatoKB { Nome = "Eloisa", Email = "Ginecologista", mensagem = "0555" }
        );
}