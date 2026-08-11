# 🚀 Cleo-IA - O Guia Supremo de Codificação SCM / CLEO 5.4 para GTA SA v1.0 US/SAMP

Salve! Este repositório é uma base de conhecimento massiva, ultra-estruturada e cirúrgica que eu montei com um objetivo claro: **dar um "super cérebro" para Modelos de Linguagem (como o Qwen Coder)** para que eles programem scripts CLEO impecáveis, modernos e com taxa zero de falhas.

Aqui não tem achismo ou código legado reaproveitado da internet. Reuni a documentação real do Sanny Builder 4, regras de engenharia de memória de baixo nível da CLEO 5+ e os piores erros de compilação/execução estruturados de um jeito que qualquer IA consegue fazer cruzamento de dados de forma perfeita antes de cuspir o código.

---

## 📂 Anatomia do Repositório (Estrutura Completa de Dados)

Cada pasta foi criada para agir como um banco de dados contextual (RAG). Veja como o ecossistema está blindado:

### 1. 📖 Introduction & Credits
*   **O que faz:** Dá o ponto de partida. Introduz a IA ao ambiente do Sanny Builder e dá os devidos créditos aos desenvolvedores e ferramentas que mantêm a cena do modding viva.

### 📝 Language (Sintaxe e Tipos de Dados)
*   **O que faz:** Ensina a IA a falar a linguagem do jogo do jeito certo. Define as regras de tipos de dados (`byte`, `dword`, `float`) e manipulação estrita de strings (aspas simples `'...'` para literais curtos de até 15 caracteres como nomes de scripts vs aspas duplas `"..."` para mensagens longas). Ensina também a chamar modelos de arquivos nativos usando a hashtag `#` (ex: `#M4`, `#CHROMEGUN`).

### ⚙️ Edit Modes (Modos de Edição do SB4)
*   **O que faz:** Documenta as diretrizes modernas de compilação do Sanny Builder 4. Isso impede que a IA utilize formatações antigas e defasadas que quebram nos compiladores atuais.

### 📊 Scm Documentation / Gta San Andreas (O Manual da Engine)
*   **O que faz:** O "mapa físico" dos limites do jogo. Informa à IA os limites estritos da engine do GTA SA v1.0 US: limite de 32 variáveis locais por thread, quantidade máxima de scripts rodando ao mesmo tempo (96), IDs nativos de clima (weather), geradores de carros e blips de radar. Impede que a IA crie códigos gigantes que dão estouro de memória no jogo.

### 🛠️ TroubleShooting / Error Messages (O Guia de Debug)
*   **O que faz:** Uma enciclopédia com os códigos de erro do compilador (do erro 0001 em diante). Se o usuário reportar um erro, a IA consulta essa pasta, localiza o problema e sabe exatamente como consertar.

### 🔬 OffSets & Memória (A Bíblia do Memory Hacking)
*   **O que faz:** Mapeamento bruto extraído diretamente da GTAMods Wiki com os endereços hexadecimais estáticos da versão v1.0 US (`GTA_SA.EXE`). Cobre dados cruciais como Dinheiro, Nível de Procurado, Gravidade, Timers, Rendering (DirectX/D3D9 Hooks) e as tabelas dinâmicas de progresso de estatísticas. 

### 🛡️ Avoid this error (A Pasta Anti-Bug)
Esta pasta guarda os aprendizados mais valiosos que descobrimos na marra durante o desenvolvimento:
*   **`error_0001.txt` a `error_0003.txt`:** Regras contra o uso de comandos fantasmas ou sintaxes quebradas.
*   **`error_0004.txt`:** Explica o perigo do comando `SET_LVAR_INT`. Mostra que passar hexadecimais grandes em opcodes antigos faz o compilador gerar um ponteiro nulo (`0x0`), causando a suspensão do script pela CLEO 5.4.0. Orienta o uso estrito de comandos inline.
*   **`error_0007.txt`:** Detalha como loops condicionais (`if/then/end`) mal alinhados com comandos de desvio de fluxo (`jump`) travam a thread do jogo, acionando o Watchdog de 5 segundos (`DebugUtils.Limits.Time = 5`) do arquivo `cleo.ini` e forçando o fechamento do GTA.

### 🧩 CLEO5 Plugins (Modular Extensions)
Informa à IA que o ambiente de execução possui 11 extensões nativas ativas no diretório `cleo_plugins` (como `SA.MemoryOperations.cleo`, `SA.Math.cleo`, `SA.IniFiles.cleo`), o que permite o uso de manipulação de memória avançada em estilo C, tratamento de arquivos de configuração `.ini` externos e cálculos trigonométricos sem recorrer a opcodes legados do GTA.

### 🎯 Examples Cleo (A Prática)
A nossa galeria de templates definitivos para a IA imitar. Contém scripts reais de referência que aplicam lógicas complexas de Toggle (liga/desliga com anti-spam por tecla) e injeção contínua de dados na memória.

---

## 🤖 Como Treinar e Controlar sua IA (O Arquivo de Ordem Raiz)

Na raiz do repositório, incluí o arquivo **`IA_Leia-me.txt`** (ou `AI_README_ROOT.txt`). Ele funciona como o prompt de sistema mandatório para o interpretador de IA. 

Toda vez que a IA ler este repositório, ela é **obrigada** a seguir as diretrizes desse arquivo:
1.  **Zero Alucinação/Delírio:** Se a IA não souber uma offset ou comando, ela está proibida de inventar ou chutar. Ela deve usar suas ferramentas de busca para pesquisar em fontes reais (*GTAMods Wiki*, *Sanny Docs*, *CLEO Library*) ou admitir que não tem o dado.
2.  **Banimento do Padrão Legado:** Bloqueia terminantemente o uso de comandos ultrapassados da CLEO 3/CLEO 4 (como a diretiva solta `thread "NOME"` que gera o Erro 0013) e exige o padrão moderno da CLEO 5.4.

---

## 📩 Contato / Parcerias
Ideias de modificações avançadas, engenharia de prompt ou modding de SAMP?
*   **Instagram:** [@eu.japex](https://www.instagram.com/eu.japex/)

## 🤝 Créditos
Documentação técnica consolidada, traduzida e adaptada a partir dos manuais oficiais da **CLEO Library**, **Sanny Builder Team** e do acervo histórico da **GTAMods Wiki**.
