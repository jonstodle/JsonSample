using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSample
{
	class Program
	{
		static void Main(string[] args)
		{
			var json = "{'expand':'schema,names','startAt':0,'maxResults':50,'total':139,'issues':[{'expand':'operations,versionedRepresentations,editmeta,changelog,transitions,renderedFields','id':'20930','self':'https://clientname.atlassian.net/rest/api/2/issue/20930','key':'-139','fields':{'summary':'Rebate','issuetype':{'self':'https://clientname.atlassian.net/rest/api/2/issuetype/1','id':'1','description':'A fee negotiation or quote','iconUrl':'https://clientname.atlassian.net/images/icons/issuetypes/sales.png','name':'Fees','subtask':false},'components':[],'created':'2015-07-10T12:29:05.000+1000','description':'Execute as per attached instruction','project':{'self':'https://clientname.atlassian.net/rest/api/2/project/10013','id':'10013','key':'--','name':'Change Instructions','avatarUrls':{'48x48':'https://clientname.atlassian.net/secure/projectavatar?avatarId=10011','24x24':'https://clientname.atlassian.net/secure/projectavatar?size=small&avatarId=10011','16x16':'https://clientname.atlassian.net/secure/projectavatar?size=xsmall&avatarId=10011','32x32':'https://clientname.atlassian.net/secure/projectavatar?size=medium&avatarId=10011'}},'reporter':{'self':'https://clientname.atlassian.net/rest/api/2/user?username=rajap','name':'rajap','key':'rajap','emailAddress':'email.au','avatarUrls':{'48x48':'https://clientname.atlassian.net/secure/useravatar?avatarId=10142','24x24':'https://clientname.atlassian.net/secure/useravatar?size=small&avatarId=10142','16x16':'https://clientname.atlassian.net/secure/useravatar?size=xsmall&avatarId=10142','32x32':'https://clientname.atlassian.net/secure/useravatar?size=medium&avatarId=10142'},'displayName':'Prabu','active':true,'timeZone':'US'},'priority':{'self':'https://clientname.atlassian.net/rest/api/2/priority/3','iconUrl':'https://clientname.atlassian.net/images/icons/priorities/major.png','name':'Medium','id':'3'},'resolution':null,'duedate':'2015-07-15','comment':{'startAt':0,'maxResults':1,'total':1,'comments':[{'self':'https://clientname.atlassian.net/rest/api/2/issue/20930/comment/24290','id':'24290','author':{'self':'https://clientname.atlassian.net/rest/api/2/user?username=acahill','name':'acahill','key':'acahill','emailAddress':'email','avatarUrls':{'48x48':'https://clientname.atlassian.net/secure/useravatar?avatarId=10142','24x24':'https://clientname.atlassian.net/secure/useravatar?size=small&avatarId=10142','16x16':'https://clientname.atlassian.net/secure/useravatar?size=xsmall&avatarId=10142','32x32':'https://clientname.atlassian.net/secure/useravatar?size=medium&avatarId=10142'},'displayName':'Andrew Cahill','active':true,'timeZone':'US'},'body':'John, please action','updateAuthor':{'self':'https://clientname.atlassian.net/rest/api/2/user?username=acahill','name':'acahill','key':'acahill','emailAddress':'email','avatarUrls':{'48x48':'https://clientname.atlassian.net/secure/useravatar?avatarId=10142','24x24':'https://clientname.atlassian.net/secure/useravatar?size=small&avatarId=10142','16x16':'https://clientname.atlassian.net/secure/useravatar?size=xsmall&avatarId=10142','32x32':'https://clientname.atlassian.net/secure/useravatar?size=medium&avatarId=10142'},'displayName':'Andrew','active':true,'timeZone':'US'},'created':'2015-07-10T12:35:43.728+1000','updated':'2015-07-10T12:35:43.728+1000'}]},'votes':{'self':'https://clientname.atlassian.net/rest/api/2/issue/-139/votes','votes':0,'hasVoted':false},'assignee':{'self':'https://clientname.atlassian.net/rest/api/2/user?username=olearyj','name':'olearyj','key':'olearyj','emailAddress':'email','avatarUrls':{'48x48':'https://clientname.atlassian.net/secure/useravatar?avatarId=10142','24x24':'https://clientname.atlassian.net/secure/useravatar?size=small&avatarId=10142','16x16':'https://clientname.atlassian.net/secure/useravatar?size=xsmall&avatarId=10142','32x32':'https://clientname.atlassian.net/secure/useravatar?size=medium&avatarId=10142'},'displayName':'John','active':true,'timeZone':'US'},'status':{'self':'https://clientname.atlassian.net/rest/api/2/status/1','description':'The issue is open and ready for the assignee to start work on it.','iconUrl':'https://clientname.atlassian.net/images/icons/statuses/open.png','name':'Open','id':'1','statusCategory':{'self':'https://clientname.atlassian.net/rest/api/2/statuscategory/2','id':2,'key':'new','colorName':'blue-gray','name':'To Do'}}}}]}";
			var result = JsonConvert.DeserializeObject<RootObject>(json);
			foreach (var item in result.issues)
			{
				Console.WriteLine(item.fields.summary);
			}
		}
	}

	public class Issuetype
	{
		public string self { get; set; }
		public string id { get; set; }
		public string description { get; set; }
		public string iconUrl { get; set; }
		public string name { get; set; }
		public bool subtask { get; set; }
	}

	public class AvatarUrls
	{
		public string __invalid_name__48x48 { get; set; }
		public string __invalid_name__24x24 { get; set; }
		public string __invalid_name__16x16 { get; set; }
		public string __invalid_name__32x32 { get; set; }
	}

	public class Project
	{
		public string self { get; set; }
		public string id { get; set; }
		public string key { get; set; }
		public string name { get; set; }
		public AvatarUrls avatarUrls { get; set; }
	}

	public class AvatarUrls2
	{
		public string __invalid_name__48x48 { get; set; }
		public string __invalid_name__24x24 { get; set; }
		public string __invalid_name__16x16 { get; set; }
		public string __invalid_name__32x32 { get; set; }
	}

	public class Reporter
	{
		public string self { get; set; }
		public string name { get; set; }
		public string key { get; set; }
		public string emailAddress { get; set; }
		public AvatarUrls2 avatarUrls { get; set; }
		public string displayName { get; set; }
		public bool active { get; set; }
		public string timeZone { get; set; }
	}

	public class Priority
	{
		public string self { get; set; }
		public string iconUrl { get; set; }
		public string name { get; set; }
		public string id { get; set; }
	}

	public class AvatarUrls3
	{
		public string __invalid_name__48x48 { get; set; }
		public string __invalid_name__24x24 { get; set; }
		public string __invalid_name__16x16 { get; set; }
		public string __invalid_name__32x32 { get; set; }
	}

	public class Author
	{
		public string self { get; set; }
		public string name { get; set; }
		public string key { get; set; }
		public string emailAddress { get; set; }
		public AvatarUrls3 avatarUrls { get; set; }
		public string displayName { get; set; }
		public bool active { get; set; }
		public string timeZone { get; set; }
	}

	public class AvatarUrls4
	{
		public string __invalid_name__48x48 { get; set; }
		public string __invalid_name__24x24 { get; set; }
		public string __invalid_name__16x16 { get; set; }
		public string __invalid_name__32x32 { get; set; }
	}

	public class UpdateAuthor
	{
		public string self { get; set; }
		public string name { get; set; }
		public string key { get; set; }
		public string emailAddress { get; set; }
		public AvatarUrls4 avatarUrls { get; set; }
		public string displayName { get; set; }
		public bool active { get; set; }
		public string timeZone { get; set; }
	}

	public class Comment2
	{
		public string self { get; set; }
		public string id { get; set; }
		public Author author { get; set; }
		public string body { get; set; }
		public UpdateAuthor updateAuthor { get; set; }
		public string created { get; set; }
		public string updated { get; set; }
	}

	public class Comment
	{
		public int startAt { get; set; }
		public int maxResults { get; set; }
		public int total { get; set; }
		public List<Comment2> comments { get; set; }
	}

	public class Votes
	{
		public string self { get; set; }
		public int votes { get; set; }
		public bool hasVoted { get; set; }
	}

	public class AvatarUrls5
	{
		public string __invalid_name__48x48 { get; set; }
		public string __invalid_name__24x24 { get; set; }
		public string __invalid_name__16x16 { get; set; }
		public string __invalid_name__32x32 { get; set; }
	}

	public class Assignee
	{
		public string self { get; set; }
		public string name { get; set; }
		public string key { get; set; }
		public string emailAddress { get; set; }
		public AvatarUrls5 avatarUrls { get; set; }
		public string displayName { get; set; }
		public bool active { get; set; }
		public string timeZone { get; set; }
	}

	public class StatusCategory
	{
		public string self { get; set; }
		public int id { get; set; }
		public string key { get; set; }
		public string colorName { get; set; }
		public string name { get; set; }
	}

	public class Status
	{
		public string self { get; set; }
		public string description { get; set; }
		public string iconUrl { get; set; }
		public string name { get; set; }
		public string id { get; set; }
		public StatusCategory statusCategory { get; set; }
	}

	public class Fields
	{
		public string summary { get; set; }
		public Issuetype issuetype { get; set; }
		public List<object> components { get; set; }
		public string created { get; set; }
		public string description { get; set; }
		public Project project { get; set; }
		public Reporter reporter { get; set; }
		public Priority priority { get; set; }
		public object resolution { get; set; }
		public string duedate { get; set; }
		public Comment comment { get; set; }
		public Votes votes { get; set; }
		public Assignee assignee { get; set; }
		public Status status { get; set; }
	}

	public class Issue
	{
		public string expand { get; set; }
		public string id { get; set; }
		public string self { get; set; }
		public string key { get; set; }
		public Fields fields { get; set; }
	}

	public class RootObject
	{
		public string expand { get; set; }
		public int startAt { get; set; }
		public int maxResults { get; set; }
		public int total { get; set; }
		public List<Issue> issues { get; set; }
	}
}
