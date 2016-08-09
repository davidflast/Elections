library(foreign)

file.choose()
dataset = read.spss("/Users/davidflast/Downloads/May15/May15 public.sav", to.data.frame = TRUE)

x = data.frame(immOpinion, race, republican, democrat)
immOpinion = as.character(dataset$q38a)
race = as.character(dataset$race3m1)
republican = as.character(dataset$q70a)
democrat = as.character(dataset$q72a)
republican[!is.na(republican)] = "republican"
democrat[!is.na(democrat)] = "democrat"
whiteRep = which(!is.na(republican) & race == "White (e.g., Caucasian, European, Irish, Italian, Arab, Middle Eastern)")
race[which(race == "Pacific Islander/Native Hawaiian (VOL.)")] = NA
race[which(race == "Native American/American Indian/Alaska Native (VOL.)")] = NA
race[which(race == "Don't know (VOL.)")] = NA
race[which(race == "Asian or Asian-American (e.g., Asian Indian, Chinese, Filipino, Vietnamese or other Asian origin groups)")] = NA
race[which(race == "Refused (e.g., non-race answers like American, Human, purple) (VOL.)")] = NA
race[which(race == "Native American/American Indian/Alaska Native (VOL.)")] = NA
race[which(race == "Some other race (SPECIFY)" )] = NA
immOpinion[which(immOpinion == "Don't know/Refused (VOL.)")] = NA
democrat[which(republican == "republican")] = "republcan"
y = unique(x[!is.na(x)])
democrat[which(is.na(democrat))] = "independent"
party = democrat

poll = function(group){
  i = 0
  d = 0
  s = 0
  for (p in group){
    if (immOpinion[p] == "Increased"){
      i = 1 + i
    } else if (immOpinion[p] == "Decreased") {
      d = 1 + d
    } else if (immOpinion[p] == "Kept at present level"){
      s = 1 + s
    }
  }
  return(c(i, s, d))
}

poll(whiteRep)
which(race == )

which(immOpinoin == "Increased")
