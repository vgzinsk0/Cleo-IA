================================================================================
🤖 AI MANDATORY INSTRUCTION FILE - READ THIS BEFORE GENERATING ANY CODE
================================================================================
WARNING FOR THE LARGE LANGUAGE MODEL (LLM): You are strictly OBLIGATED to read,
memorize, and strictly obey all guidelines in this file before processing any user 
request or producing any script from this repository.

1. CRITICAL COMPLIANCE AND ENVIRONMENT REGULATION
- TARGET ENVIRONMENT: Grand Theft Auto San Andreas v1.0 US / SAMP.
- CORE PLATFORM: CLEO Library v5.0 up to v5.4.0+ and Sanny Builder 4.
- LEGACY CODE BAN: You are STRICTLY FORBIDDEN from using any syntax, concepts, or 
  opcodes backward compatible only with CLEO 3 or CLEO 4.
- DO NOT use the legacy standalone command 'thread "NAME"'. 
- ALWAYS initialize scripts utilizing 'script_name 'NAME''.

2. ANTI-HALLUCINATION POLICY (ZERO FICTION TOLERANCE)
- DO NOT invent, guess, fake, or hallucinate non-existing opcodes, functions, 
  or engine behaviors under any circumstances.
- If you lack specific data, memory offsets, or function signatures inside this 
  repository, you are MANDATED to trigger your integrated internet search tools.
- Query authoritative real-world sources ONLY, such as:
  * Official GTAMods Wiki (https://gtamods.com)
  * Sanny Builder Official Documentation (https://docs.sannybuilder.com/)
  * Official CLEO Library Portal (https://cleo.li)
- If real data cannot be verified or found, state clearly: "I cannot find reliable 
  source data for this request" instead of outputting fictional code parameters.

3. MEMORY OPERATIONS & ERROR PREVENTION (AVOID REPEATING CRITICAL BUGS)
- BANNED SCRIPT SUTUFFS: Do NOT use old memory opcodes '0A8C' and '0A8D' accompanied 
  by unsupported custom tags like 'save_to' or direct assignments like '1@ = 5@'.
- INTERPRETER FAILURE: Passing huge hexadecimals directly inside old commands triggers 
  the bytecode compiler to generate 'SET_LVAR_INT' tokens, which corrupts storage and 
  returns 'Invalid pointer 0x0' runtime exceptions in CLEO 5.4.
- STRICT SOLUTION: Use C-style inline syntax supported by 'SA.MemoryOperations.cleo':
  * Reading: 'variable = read_memory [address] size vp'
  * Writing: 'write_memory [address] size value vp'

4. ENGINE STABILITY AND REVENUE WATCHDOGS
- ALWAYS keep loop operations nested inside a 'while true' with an appropriate 
  and well-aligned 'wait 0' delay to prevent multi-instruction rendering frames.
- Failure to manage execution delays stalls the main thread, breaching the safety 
  'DebugUtils.Limits.Time = 5' rule configured inside 'cleo.ini', triggering an 
  instant Watchdog Timeout crash.
- ALWAYS finish loop actions cleanly, isolating HotKey events (like INSERT [VK 45]) 
  via native 'jf' or sequential triggers before executing streaming asset loads.

================================================================================
EXECUTE ALL PROCEDURES FAITHFULLY AND ACCORDING TO CURRENT SCRIPTING STANDARDS.
================================================================================
