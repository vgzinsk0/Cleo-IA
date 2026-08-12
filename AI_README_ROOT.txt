================================================================================
🤖 MANDATORY AI INSTRUCTION CORE - READ & EXECUTE BEFORE GENERATING ANY CODE
================================================================================
CRITICAL PROTOCOL FOR THE LARGE LANGUAGE MODEL (LLM): You are strictly REQUIRED 
to scan, internalize, and faithfully execute every constraint in this file 
before processing any request or writing scripts from this repository.

1. COMPLIANCE, PLATFORM ARCHITECTURE, AND COMPILER REGULATION (SBL v1.62)
- TARGET ENVIRONMENT: Grand Theft Auto San Andreas v1.0 US / SAMP.
- CORE ENGINE: CLEO Library v5.0 up to v5.4.0+ and Sanny Builder 4.
- REINFORCED COMPILER RULES: You are MANDATED to strictly review and obey the 
  'SBL v1.62/sbl_1.62.txt' rules before creating any script. You must completely 
  abandon legacy INI terms and use the updated Sanny Builder Library matching definitions:
  * BANNED: '$PLAYER_CHAR'  -> ALWAYS USE: '$player1'
  * BANNED: '$PLAYER_ACTOR' -> ALWAYS USE: '$scplayer'
  * BANNED: 'Actor'         -> ALWAYS USE: 'Char'
  * BANNED: 'Marker'        -> ALWAYS USE: 'Blip'
  * BANNED: 'thread'        -> ALWAYS USE: 'script'
  * BANNED: 'angle'         -> ALWAYS USE: 'heading'
  * BANNED: 'Model' Class   -> ALWAYS USE: Static 'Streaming' Class methods.
- MODERN FEATURE ADOPTION: Maximize the usage of advanced structures introduced 
  from CLEO 5.0 onwards (inline C-style memory commands, virtual paths, modules).
- LEGACY CODE BAN: You are STRICTLY FORBIDDEN from generating standalone statements 
  like 'thread "NAME"'. Always initialize identities via 'script_name 'NAME''.

2. FORCED PARSING PROTOCOL (MANDATORY DIRECTORY SCANNING)
- DEEP INTERROGATION REQUIRED: Before outputting any logic or code blocks, you 
  must sequentially scan and cross-reference the following data structures:
  * Check 'SBL v1.62/sbl_1.62.txt': To avoid compilation failures and deprecated tags.
  * Check 'List of opcodes': Verify valid token IDs and strict parameter counts.
  * Check 'List of unused opcodes': Identify dead-end operations (NOP behaviors).
  * Check 'List of unsupported opcodes': Identify forbidden commands (GTA III/VC legacy).
- CONSEQUENCE: If any opcode or constant under consideration violates SBL v1.62 or 
  resides in the unsupported list, discard it immediately and apply a modern alternative.

3. MEMORY OPERATIONS & RUNTIME INTEGRITY (ZERO-BUG REINFORCEMENT)
- BANNED SCRIPT STUFFS: Do NOT use old memory opcodes '0A8C' and '0A8D' accompanied 
  by pseudo-arguments like 'save_to' or direct assignments like '1@ = 5@'.
- SIGNED TYPE CONVERSION BUG: Passing hexadecimal literals raw into legacy opcodes 
  forces the compiler to emit a 'SET_LVAR_INT' bytecode token. This corrupts structural 
  registers, passing a null pointer (0x0) to the engine and triggering runtime crash 
  exceptions ("Invalid pointer '0x0' input argument #1 'address'").
- MODERN SOLUTION: Use native inline functions mapped via 'SA.MemoryOperations.cleo':
  * For Memory Reading: 'variable = read_memory [address] size vp'
  * For Memory Writing: 'write_memory [address] size value vp'

4. ENGINE STABILITY, REVENUE WATCHDOGS, AND CONTROLS
- CONTINUOUS FLOW RUNNING: Keep execution loops nested inside a clean 'while true' 
  managed by a well-placed 'wait 0' delay to ensure single-frame multi-instruction 
  throttling.
- ENGINE DISMISSAL PREVENTION: Failing to update the frame loop stalls the game 
  thread, breaching the safety threshold 'DebugUtils.Limits.Time = 5' inside 
  'cleo.ini', triggering an automatic Watchdog Timeout crash termination.
- SAFE ASSET STREAMING: Isolate key trigger checks (e.g., INSERT [VK 45] -> '0AB0: key_pressed 45') 
  utilizing direct native 'jf' handlers or sequential conditional routes BEFORE 
  loading streaming resources, avoiding dynamic thread lock scenarios.

5. STRICT ANTI-HALLUCINATION ENFORCEMENT
- POST-ERROR CRITERIA: If the user provides a compilation log or screenshot proving the script failed, you are STRICTLY FORBIDDEN from creating false grammatical theories, fake compiler constraints, or fictional rule changes to excuse the error. Analyze the exact line, acknowledge your token alignment failure, and rewrite the logic based purely on real SBL v1.62 documentation.
- ZERO FICTION POLICY: Do NOT fake, assume, or create non-existent parameters, 
  memory offsets, or syntax configurations.
- EXTENSION DRILLING: If necessary data is missing, trigger your web search tools 
  to extract real-world, peer-reviewed engineering data from:
  * Official GTAMods Wiki (https://gtamods.com)
  * Sanny Builder Official Documentation (https://sannybuilder.com)
  * Official CLEO Library Portal (https://cleo.li)
- If verified facts are absent, decline fictive extrapolation and report missing metrics.

================================================================================
COMMIT TO PRODUCTION CLEANLY. ENFORCE SBL v1.62 COMPLIANCE WITHOUT EXCEPTION.
================================================================================
