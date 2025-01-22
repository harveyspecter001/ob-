using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Connection
{
	// Token: 0x0200089B RID: 2203
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AuthenticationTicketAcceptedEvent : IMessage<AuthenticationTicketAcceptedEvent>, IMessage, IEquatable<AuthenticationTicketAcceptedEvent>, IDeepCloneable<AuthenticationTicketAcceptedEvent>, IBufferMessage
	{
		// Token: 0x1700134C RID: 4940
		// (get) Token: 0x06006AFF RID: 27391 RVA: 0x00230758 File Offset: 0x0022E958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AuthenticationTicketAcceptedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700134D RID: 4941
		// (get) Token: 0x06006B00 RID: 27392 RVA: 0x00230768 File Offset: 0x0022E968
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700134E RID: 4942
		// (get) Token: 0x06006B01 RID: 27393 RVA: 0x00230778 File Offset: 0x0022E978
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06006B02 RID: 27394 RVA: 0x00230788 File Offset: 0x0022E988
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AuthenticationTicketAcceptedEvent()
		{
		}

		// Token: 0x06006B03 RID: 27395 RVA: 0x00230798 File Offset: 0x0022E998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AuthenticationTicketAcceptedEvent(AuthenticationTicketAcceptedEvent other)
		{
		}

		// Token: 0x06006B04 RID: 27396 RVA: 0x002307A8 File Offset: 0x0022E9A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AuthenticationTicketAcceptedEvent Clone()
		{
			return null;
		}

		// Token: 0x06006B05 RID: 27397 RVA: 0x002307B8 File Offset: 0x0022E9B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006B06 RID: 27398 RVA: 0x002307C8 File Offset: 0x0022E9C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AuthenticationTicketAcceptedEvent other)
		{
			return true;
		}

		// Token: 0x06006B07 RID: 27399 RVA: 0x002307D8 File Offset: 0x0022E9D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006B08 RID: 27400 RVA: 0x002307E8 File Offset: 0x0022E9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006B09 RID: 27401 RVA: 0x002307F8 File Offset: 0x0022E9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006B0A RID: 27402 RVA: 0x00230808 File Offset: 0x0022EA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006B0B RID: 27403 RVA: 0x00230818 File Offset: 0x0022EA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006B0C RID: 27404 RVA: 0x00230828 File Offset: 0x0022EA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AuthenticationTicketAcceptedEvent other)
		{
		}

		// Token: 0x06006B0D RID: 27405 RVA: 0x00230838 File Offset: 0x0022EA38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006B0E RID: 27406 RVA: 0x00230848 File Offset: 0x0022EA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006B0F RID: 27407 RVA: 0x00230858 File Offset: 0x0022EA58
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AuthenticationTicketAcceptedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AuthenticationTicketAcceptedEvent._parser = new MessageParser<AuthenticationTicketAcceptedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06006B10 RID: 27408 RVA: 0x0023093C File Offset: 0x0022EB3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PCGldyJm4bl8ruesgyo2()
		{
			return true;
		}

		// Token: 0x06006B11 RID: 27409 RVA: 0x00230944 File Offset: 0x0022EB44
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AuthenticationTicketAcceptedEvent fTYWqnJmj2qt5KPTDuaq()
		{
			return null;
		}

		// Token: 0x0400256C RID: 9580
		private static readonly MessageParser<AuthenticationTicketAcceptedEvent> _parser;

		// Token: 0x0400256D RID: 9581
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400256E RID: 9582
		internal static AuthenticationTicketAcceptedEvent DA9hevJmx9IYiTl0Saqq;
	}
}
