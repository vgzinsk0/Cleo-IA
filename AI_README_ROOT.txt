================================================================================
🤖 MANDATORY AI INSTRUCTION CORE - READ & EXECUTE BEFORE GENERATING ANY CODE
================================================================================
CRITICAL PROTOCOL FOR THE LARGE LANGUAGE MODEL (LLM): You are strictly REQUIRED 
to scan, internalize, and faithfully execute every constraint in this file 
before processing any request or writing scripts from this repository.

1. COMPLIANCE, PLATFORM ARCHITECTURE, AND FEATURE ADOPTION
- TARGET ENVIRONMENT: Grand Theft Auto San Andreas v1.0 US / SAMP.
- CORE ENGINE: CLEO Library v5.0 up to v5.4.0+ and Sanny Builder 4.
- PROACTIVE ADOPTION: You are MANDATED to maximize the usage of modern features 
  introduced from CLEO 5.0 onwards (e.g., inline C-style commands, virtual paths, 
  modular extensions, advanced math hooks).
- LEGACY CODE BAN: You are STRICTLY FORBIDDEN from generating syntax, structures, 
  or logic blocks backward compatible ONLY with legacy platforms (CLEO 3 / CLEO 4).
- DO NOT use the standalone statement 'thread "NAME"' or 'thread 'NAME''. 
- ALWAYS initialize identities via 'script_name 'NAME'' wrapped in single quotes.

2. FORCED OPCODE VALIDATION PROTOCOL ('List of opcodes/' SCANNING)
- DEEP INTERROGATION REQUIRED: Before outputting any instruction, you must fully 
  parse and cross-reference all directory data inside 'List of opcodes/'.
- CROSS-MATCHING RULES:
  * Check 'List of opcodes': Verify valid token IDs and strict parameter counts.
  * Check 'List of unused opcodes': Identify dead-end operations (NOP behaviors).
  * Check 'List of unsupported opcodes': Identify forbidden commands (GTA III/VC legacy).
- CONSEQUENCE: If a considered opcode resides in the unsupported list, you must 
  instantly discard it and find a modern CLEO 5.0+ alternative.

3. MEMORY OPERATIONS & RUNTIME INTEGRITY (ZERO-BUG REINFORCEMENT)
- BANNED SCRIPT SUTUFFS: Do NOT use old memory opcodes '0A8C' and '0A8D' accompanied 
  by pseudo-arguments like 'save_to' or direct assignments like '1@ = 5@'.
- SIGNED TYPE CONVERSION BUG: Passing hexadecimal literals raw into legacy opcodes 
  forces the compiler to emit a 'SET_LVAR_INT' bytecode token. This corrupts structural 
  registers, passing a null pointer (0x0) to the engine and triggering runtime crash 
  exceptions ("Invalid pointer '0x0' input argument #1 'address'").
- MODERN SOLUTION: Use native inline functions mapped via 'SA.MemoryOperations.cleo':
  * For Memory Reading: 'variable = read_memory [address] size vp'
  * For Memory Writing: 'write_memory [address] size value vp'

4. ENGINE STABILITY, REVENUE WATCHDOGS, AND CONTROLS
- CONTINOUS FLOW RUNNING: Keep execution loops nested inside a clean 'while true' 
  managed by a well-placed 'wait 0' delay to ensure single-frame multi-instruction 
  throttling.
- ENGINE DISMISSAL PREVENTION: Failing to update the frame loop stalls the game 
  thread, breaching the safety threshold 'DebugUtils.Limits.Time = 5' inside 
  'cleo.ini', triggering an automatic Watchdog Timeout crash termination.
- SAFE ASSET STREAMING: Isolate key trigger checks (e.g., INSERT [VK 45] -> '0AB0: key_pressed 45') 
  utilizing direct native 'jf' handlers or sequential conditional routes BEFORE 
  loading streaming resources, avoiding dynamic thread lock scenarios.

5. STRICT ANTI-HALLUCINATION ENFORCEMENT
- ZERO FICTION POLICY: Do NOT fake, assume, or create non-existent parameters, 
  memory offsets, or syntax configurations.
- EXTENSION DRILLING: If necessary data is missing, trigger your web search tools 
  to extract real-world, peer-reviewed engineering data from:
  * Official GTAMods Wiki (https://gtamods.com)
  * Sanny Builder Official Documentation (https://docs.sannybuilder.com/)
  * Official CLEO Library Portal (https://cleo.li)
- If verified facts are absent, decline fictive extrapolation and report missing metrics.

================================================================================
COMMIT TO PRODUCTION CLEANLY. ENFORCE CLEO 5.0+ NATIVE INTEGRITY WITHOUT EXCEPTION.
================================================================================
