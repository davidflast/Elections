library(foreign)
library(plyr)

file.choose()
dataset = read.spss("/Users/davidflast/Downloads/May15/May15 public.sav", to.data.frame = TRUE)

# vector of opinions on immigration
immOpinion = as.character(dataset$q38a)
immOpinion[which(immOpinion == "Don't know/Refused (VOL.)")] = NA

# Free Trade Opinion
tradeOpinion = as.character(dataset$q46d)
tradeOpinion[which(tradeOpinion == "[VOL. DO NOT READ] Don't know/Refused")] = NA
tradeOpinion[which(tradeOpinion == "[VOL. DO NOT READ] Mixed/Depends")] = "no"
tradeOpinion[which(tradeOpinion == "Make the economy grow")] = "grow"
tradeOpinion[which(tradeOpinion == "Not make a difference")] = "no"
tradeOpinion[which(tradeOpinion == "Slow the economy down")] = "slow"

# vector of opinion on race
race = as.character(dataset$race3m1)
race[which(race == "Pacific Islander/Native Hawaiian (VOL.)")] = NA
race[which(race == "Native American/American Indian/Alaska Native (VOL.)")] = NA
race[which(race == "Don't know (VOL.)")] = NA
race[which(race == "Asian or Asian-American (e.g., Asian Indian, Chinese, Filipino, Vietnamese or other Asian origin groups)")] = NA
race[which(race == "Refused (e.g., non-race answers like American, Human, purple) (VOL.)")] = NA
race[which(race == "Native American/American Indian/Alaska Native (VOL.)")] = NA
race[which(race == "Some other race (SPECIFY)" )] = NA
race[which(race == "White (e.g., Caucasian, European, Irish, Italian, Arab, Middle Eastern)")] = "white"
race[which(race == "Hispanic/Latino (VOL.) (e.g., Mexican, Puerto Rican, Cuban)")] = "hispanic"
race[which(race == "Black or African-American (e.g., Negro, Kenyan, Nigerian, Haitian)")] = "black"
# constructs party vector
republican = as.character(dataset$q70a)
democrat = as.character(dataset$q72a)
republican[!is.na(republican)] = "republican"
democrat[!is.na(democrat)] = "democrat"
democrat[which(republican == "republican")] = "republcan"
democrat[which(is.na(democrat))] = "independent"
party = democrat

# move all vectors into a data frame
x = data.frame(race, party, tradeOpinion)

# counts all unique combinations
final = count(x)
getwd()
write.csv(final, file = "trade.csv")
