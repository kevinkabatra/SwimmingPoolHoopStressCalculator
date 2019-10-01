# SwimmingPoolHoopStressCalculator
Calculator that can be used to determine the maximum depth of water in a given circular pool.

## Background
I am a full-stack software developer currently specializing in Enterprise Resource Planning (ERP) and Point-of-Sales (POS) development. I taught myself how to program, starting my self-education in 2013 and managing to get a proper job in development in 2015. Ever since I have been specializing in retail and manufacturing software. 

I should also point out that my ability in Mathematics, outside of iterations... thank you software development, is skeptical at best. Lucky enough none of that is needed in my day to day development. This lack of skill certainly made this task more difficult than I think it otherwise had to be. But I am a talented Googler and a constant student, so I just had to hit the books to make this a reality.

You can see more of my history on [LinkedIn](https://www.linkedin.com/in/kevinkabatra/) or you can just tell me how awesome you think I am.

## Inspiration
I was inspired to do this while reading *How To* written by Randall Munroe, which can be purchased from Amazon [here](https://smile.amazon.com/How-Randall-Munroe/dp/1473680328/ref=asc_df_1473680328/?tag=hyprod-20&linkCode=df0&hvadid=366402537587&hvpos=1o2&hvnetw=g&hvrand=7278845996996595821&hvpone=&hvptwo=&hvqmt=&hvdev=c&hvdvcmdl=&hvlocint=&hvlocphy=9012056&hvtargid=pla-814089623439&psc=1&tag=&ref=&adgrpid=77768497578&hvpone=&hvptwo=&hvadid=366402537587&hvpos=1o2&hvnetw=g&hvrand=7278845996996595821&hvqmt=&hvdev=c&hvdvcmdl=&hvlocint=&hvlocphy=9012056&hvtargid=pla-814089623439&sa-no-redirect=1). In this book he has a chapter dedicated to building an absurd swimming pool, and he determines how much water you can store in a swimming pool prior to the wall rupturing based on the type of material that the wall is made out of. The formula seemed simple enough to comprehend, and so I set out to make a C# solution that would calculate this awesomeness for me.

What I did not anticipate is how complicated fluid mechanics actual are and how much information I would need to digest in order to make this a reality. Not to be beaten by this project I actually managed to crank out the initial version over the course of a two-day weekend.

### The formula
water depth = (wall thickness * tensile strength of wall material) / (water density * gravity * radius of pool)
## References / Things that I found helpful
1. Within the source you will find several web links that will navigate you to something that I found helpful, especially when getting certain constant values (gravity and water density come to mind). I won't bother including them in this document, since they are being stored in the same repository.
2. The calculator built into the Google search engine, it helped me understand that my initial math was completely gorked.
3. This video on Hoop Stress (Lame's equation) from YouTube: https://www.youtube.com/watch?v=ZeErNgYzwJI. This video enabled me to understand the equation itself. Which as simple as it seemed definitely took awhile for me to process.
4. This video on pressure in a fluid also from YouTube: https://www.youtube.com/watch?v=mzjlAla3H1Q. This professor thoroughly explained finding the internal pressure of water, which was something that I was struggling to find with several Google searches. As soon as I started his video and he referenced the density of water and gravity I knew that I was in the right place.
5. Of course Randall Munroe as he served as the initial inspiration for this, and his example was used for my first unit test.
6. My lovely wife, who happens to be a high school Mathematics teacher. I was stuck on the final step of the equation. Unable to figure out how to convert kilograms per second square and pascals into something that I could divide nicely. During this phase I happened to show her the first video, and due to my questionable skills in Math, I told her I could not understand why the centimeters were not being considered in the output of the equation. Once she explained why, it immediately helped inform my subconscious so that it could process simply removing the pascals from the equation using expression simplification. Boom. All that was left was coding the solution.
