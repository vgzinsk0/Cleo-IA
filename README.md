# 🚀 Cleo-IA - O Guia Supremo de Codificação SCM / CLEO 5.4 para GTA SA v1.0 US

Salve! Este repositório é uma base de conhecimento massiva e ultra-estruturada que eu criei com um objetivo claro: **dar um super cérebro para Inteligências Artificiais** (como o Qwen Coder) para que elas programem scripts CLEO perfeitos, sem inventar comandos e sem dar crash no jogo.

Aqui dentro não tem script genérico. Tem a documentação real do Sanny Builder estruturada de um jeito que a IA consegue cruzar dados de sintaxe, limites da engine do GTA e histórico de ferramentas.

---

## 📂 Raio-X do Repositório (Estrutura Completa)

Aqui está como organizei cada pedaço de conhecimento para a IA devorar:

### 1. 📖 Introduction & Credits
*   **O que faz:** Introduz a IA ao ecossistema do Sanny Builder e dá os créditos aos criadores das ferramentas e da documentação original. Dá o contexto inicial do ambiente de desenvolvimento.

### 2. 📝 Language (Sintaxe e Tipos de Dados)
*   **O que faz:** Ensina a IA a falar a linguagem do jogo. Explica a diferença crucial de strings (aspas simples de até 15 caracteres para nomes de scripts vs aspas duplas de 255 caracteres), manipulação de números inteiros, hexadecimais, binários, floats (decimais) e como chamar modelos usando a hashtag `#` (ex: `#INFERNUS`).

### 3. ⚙️ Edit Modes (Modos de Edição do SB4)
*   **O que faz:** Documenta as regras de compilação modernas e os guias de migração para os novos modos do Sanny Builder 4. Isso garante que a IA não use formatações antigas e defasadas que quebram nas ferramentas atuais.

### 4. 📊 Scm Documentation / Gta San Andreas (O Manual da Engine)
*   **O que faz:** Define os limites físicos do jogo para a IA não abusar da memória. Contém as tabelas exatas do GTA SA v1.0 US: limite de 32 variáveis locais, threads simultâneas, IDs nativos de clima (weather IDs), quantidade máxima de carros spawnados por script e blips de radar.

### 5. 🛠️ TroubleShooting / Error Messages (O Guia de Debug)
*   **O que faz:** Uma lista massiva com as mensagens de erro do compilador (do erro 0001 em diante). Se a IA gerar um código e o usuário reportar um erro de compilação, a IA consulta essa pasta, descobre na hora o que causou o erro e sabe exatamente como consertar.

### 6. 🔄 Version History (Evolução da CLEO)
*   **O que faz:** Mantém o histórico de atualizações das ferramentas. Essencial para a IA entender o que mudou nas versões recentes (como os novos recursos de módulos da CLEO 5) e manter o script compatível com as versões mais novas.

### 7. 🎯 Examples Cleo (A Prática)
*   **O que faz:** Pasta com códigos reais rodando perfeitamente no jogo para servir de template definitivo.
*   **Destaque atual:** O script `Godmode ON-OFF.txt`, que ensina a IA a fazer estruturas complexas de liga/desliga (toggle), aplicar imunidades ao jogador (`Actor.SetImmunities`) e fazer **Memory Hacking** avançado escrevendo direto nos endereços de memória do jogo usando o opcode `0A8C: write_memory`.

---

## 🧠 Como usar este repositório para treinar sua IA
Conecte este repositório público como um ambiente de contexto (Environment/RAG) na sua IA de código de preferência. Ao pedir um mod, use um prompt como:

> *"Crie um script CLEO para GTA SA. Consulte as pastas `Language` e `Scm Documentation` do meu repositório para garantir que a sintaxe, os limites e os comandos sejam 100% compatíveis com o GTA SA v1.0 US. Se houver falhas, use a pasta `TroubleShooting` para debugar."*

## 🤝 Créditos Técnicos
Os dados e manuais contidos aqui foram extraídos, traduzidos e adaptados das documentações oficiais da **CLEO Library** e do **Sanny Builder**.
