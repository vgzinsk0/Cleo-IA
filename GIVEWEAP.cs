{$CLEO .cs}

//===========================================
// SPAWNADOR DE ARMAS SEGURO - GIVEWEAP
// CLEO 5.4 Modern Script for GTA SA v1.0 US/SAMP
//===========================================

script_name 'GIVEWEAP'

// Variáveis locais dedicadas (limite 32: 0@ a 31@)
// 0@ = Controle do loop principal
// 1@ = Flag de ativação do kit
// 2@ = Modelo M4
// 3@ = Modelo Desert Eagle
// 4@ = Modelo Shotgun
// 5@ = Contador temporário de munição

:MAIN_LOOP
wait 0

// Verifica se o jogador existe e está jogando
if not is_player_playing $PLAYER_CHAR
then
    jump @MAIN_LOOP
end

//===========================================
// HOTKEY: INSERT (Virtual Key 45)
// Estrutura de trava WAIT_KEY_UP baseada no Godmode
//===========================================

if 8AB0: not key_pressed 45
then
    jump @MAIN_LOOP
end

// Trava até soltar a tecla INSERT (anti-repeat)
:WAIT_KEY_RELEASE
wait 0
if 8AB0: not key_pressed 45
then
    jump @WAIT_KEY_RELEASE
end

//===========================================
// REQUISIÇÃO SEGURA DE MODELOS
// Usa hashtag # antes do nome em maiúsculo
// Loop obrigatório de carregamento com wait 0
//===========================================

// Carregar modelo M4 (ID da arma: 31)
2@ = #M4
Model.Load(2@)

:M4_LOAD_CHECK
wait 0
if not Model.Available(2@)
then
    jump @M4_LOAD_CHECK
end

// Carregar modelo Desert Eagle (ID da arma: 24)
3@ = #DESERT_EAGLE
Model.Load(3@)

:DE_LOAD_CHECK
wait 0
if not Model.Available(3@)
then
    jump @DE_LOAD_CHECK
end

// Carregar modelo Shotgun (ID da arma: 25)
4@ = #SHOTGUN
Model.Load(4@)

:SG_LOAD_CHECK
wait 0
if not Model.Available(4@)
then
    jump @SG_LOAD_CHECK
end

//===========================================
// ENTREGA DE ARMAS E MUNIÇÃO AO JOGADOR
// Usa comandos nativos modernos de atribuição
//===========================================

// Dar M4 (weapon ID 31) com 500 tiros de munição
Actor.GiveWeaponAndAmmo($PLAYER_ACTOR, weapon.M4, ammo=500)

// Dar Desert Eagle (weapon ID 24) com 200 tiros de munição
Actor.GiveWeaponAndAmmo($PLAYER_ACTOR, weapon.DesertEagle, ammo=200)

// Dar Shotgun (weapon ID 25) com 100 tiros de munição
Actor.GiveWeaponAndAmmo($PLAYER_ACTOR, weapon.Shotgun, ammo=100)

//===========================================
// LIBERAÇÃO DE MEMÓRIA (CLEANUP)
// mark_model_as_no_longer_needed imediato
//===========================================

Model.MarkAsNoLongerNeeded(2@) // M4
Model.MarkAsNoLongerNeeded(3@) // Desert Eagle
Model.MarkAsNoLongerNeeded(4@) // Shotgun

//===========================================
// FEEDBACK NA TELA E SONORO
// Mensagem de alta prioridade + som nativo
//===========================================

Text.PrintHighPriority("~G~KIT DE ARMAS ATIVADO", time=3000, flag=1)

// Tocar som nativo de confirmação (ID 1139 - som de menu/select)
Sound.PlayAtPosition(1139, x=0.0, y=0.0, z=0.0)

// Retorna ao loop principal
jump @MAIN_LOOP

//===========================================
// FIM DO SCRIPT
// Terminação limpa sem thread legacy
//===========================================

terminate_custom_script
