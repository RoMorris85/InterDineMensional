INCLUDE SE2_ChefSwatts_2.ink
INCLUDE globals.ink
INCLUDE BADialogue.ink

// Would you like to retry the minigame?
//     *[Yes]
//         ~BAMLevel=1
//         ~currentConvo="cSD2"
//         ->MainBAD
//     *[No]
        ->MainFail2
    ===MainFail2===
    ~affectionCS-=2
    Ay... Still not gettin' it, huh? #speaker:Chef Swatts #mood:sad #sfx:lostPoint
    
    Y-yeah... #speaker:Graciana #mood:sad
    Why do you gotta throw the food?! Just hand it to me normally?! #speaker:Graciana #mood:angry
    
    Ay, but then it wouldn't be as fresh as it can be! #speaker:Chef Swatts #mood:angry
    
    How is throwing it at my head making it as fresh as it can be?! #speaker:Graciana
    
    It's tha most optimal timing! Quickest way to get it to tha customer while stayin' fresh! #speaker:Chef Swatts
    
    Is it still "fresh" if half the ingredients are wrong? #speaker:Graciana
    
    I mean, ya, technically speakin'. #speaker:Chef Swatts #mood:neutral
    
    ... #speaker:Graciana #mood:neutral
    
    Aight aight, lemme fix it up. I'll take it out. #speaker:Chef Swatts #mood:blank
    
    (Chef Swatts makes the burger a bit better, and takes it out to the customer. After a minute, he comes back in looking a bit disgruntled...) #speaker:Graciana #mood:think
    Something happen? #ss:Chef Swatts:angry
    
    I dunno what that lady's deal is. She actin' like she never seen a fly be a chef before! #speaker:Chef Swatts #mood:angry
    
    ...Yeah... #speaker:Graciana #mood:neutral

->MainCS2