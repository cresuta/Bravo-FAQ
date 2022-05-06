-- Seed Data

USE [Bravo-FAQ];
GO

-- Question
set identity_insert [Question] on
insert into Question(Id, Content) values (1, 'Why are software updates necessary?');
insert into Question(Id, Content) values (2, 'How can I keep my software up to date?');
insert into Question(Id, Content) values (3, 'What can I find in the Microsoft Download Center, and how do I find what I am looking for?');
insert into Question(Id, Content) values (4, 'How do I find worldwide downloads?');
insert into Question(Id, Content) values (5, 'Which other Microsoft websites offer downloads?');
insert into Question(Id, Content) values (6, 'What should I do if I cannot find what I am looking for?');
insert into Question(Id, Content) values (7, 'What information will I find on download pages?');
insert into Question(Id, Content) values (8, 'What are Download Notifications?');
insert into Question(Id, Content) values (9, 'What should I do if I cannot complete a download?');
insert into Question(Id, Content) values (10, 'How do I install downloaded software?');
set identity_insert [Question] off


-- Answer
set identity_insert [Answer] on
insert into Answer (Id, Content, QuestionId) values (1, 'Microsoft is committed to providing its customers with software that has been tested for safety and security. Although no system is completely secure, we use processes, technology, and several specially focused teams to investigate, fix, and learn from security issues to help us meet this goal and to provide guidance to customers on how to help protect their PCs.

As part of the Microsoft software release process, all software released to the Download Center is scanned for malware before it is made available for public download. Additionally, after release, the software available from the Download Center is routinely scanned for malware. Microsoft recognizes that the threat environment is constantly changing and will continue to evolve over time, and we are committed to process improvements that will help protect our customers from malware threats', 1);
insert into Answer (Id, Content, QuestionId) values (2, 'Microsoft offers a range of online services to help you keep your computer up to date. Windows Update finds updates that you might not even be aware of and provides you with the simplest way to install updates that help prevent or fix problems, improve how your computer works, or enhance your computing experience. Visit Windows Update to learn more.', 2);
insert into Answer (Id, Content, QuestionId) values (3, 'The Microsoft Download Center has recently been revised to better serve you as a one-stop shop for products available for purchase, in addition to products and downloads available for free. For your convenience, items available for purchase are linked directly to Microsoft Store. Items available as free downloads are linked to details pages, where you can learn more about them and initiate downloads.', 3);
insert into Answer (Id, Content, QuestionId) values (4, 'Microsoft delivers downloads in more than 118 languages worldwide. The Download Center now combines all English downloads into a single English Download Center. We no longer offer separate downloads for U.S. English, U.K. English, Australian English, or Canadian English.', 4);
insert into Answer (Id, Content, QuestionId) values (5, 'In this section, you will find links to other Microsoft websites that offer downloads. Note that almost all of the downloads available from these websites can also be found in the Microsoft Download Center; however, the other Microsoft sites may offer services and information that you may not find in the Download Center.

If you are looking for downloads for the Windows operating system or for Microsoft Office, try using Windows Update , which helps you keep your computer up to date without requiring you to visit the Download Center.', 5);
insert into Answer (Id, Content, QuestionId) values (6, 'If you cannot find a specific download, it may be available from a company other than Microsoft. Popular examples include Adobe Reader, Macromedia Shockwave and Flash players, and Java software. For current links to these downloads on their respective websites, use Bing to search the web for the download you are looking for. If you are certain a specific download is from Microsoft and you cannot find the download in the Download Center or through our automatic update services, please contact us .', 6);
insert into Answer (Id, Content, QuestionId) values (7, 'When you click a download item in the Download Center, you will be directed to the download details page for that download. Most of these pages follow a standard format and include most of the sections described here.', 7);
insert into Answer (Id, Content, QuestionId) values (8, 'You can sign up to receive a customized email newsletter notifying you of new downloads, featured downloads, and services such as Windows Update', 8);
insert into Answer (Id, Content, QuestionId) values (9, 'If you cannot complete a download, you may need to clear the cache in Windows Internet Explorer, as described in the following steps. Note that this procedure will vary slightly, depending on the version of Internet Explorer you have installed', 9);
insert into Answer (Id, Content, QuestionId) values (10, 'Before you can use any software that you download, you must install it. For example, if you download a security update but do not install it, the update will not provide any protection for your computer.', 10);
set identity_insert [Answer] off
