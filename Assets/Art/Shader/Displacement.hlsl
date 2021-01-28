void ChangeMap_half(half input, half randomNum, half lastNum, out half Out)
{
#if SHADERGRAPH_PREVIEW
   Out = 2;
#else
    Out = 2;
    if (input == 0)
    {
        Out = randomNum;
    }
#endif
}