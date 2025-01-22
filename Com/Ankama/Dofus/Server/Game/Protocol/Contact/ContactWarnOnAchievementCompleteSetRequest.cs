using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x02000825 RID: 2085
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ContactWarnOnAchievementCompleteSetRequest : IMessage<ContactWarnOnAchievementCompleteSetRequest>, IMessage, IEquatable<ContactWarnOnAchievementCompleteSetRequest>, IDeepCloneable<ContactWarnOnAchievementCompleteSetRequest>, IBufferMessage
	{
		// Token: 0x17001254 RID: 4692
		// (get) Token: 0x06006561 RID: 25953 RVA: 0x0022A66C File Offset: 0x0022886C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ContactWarnOnAchievementCompleteSetRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001255 RID: 4693
		// (get) Token: 0x06006562 RID: 25954 RVA: 0x0022A67C File Offset: 0x0022887C
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

		// Token: 0x17001256 RID: 4694
		// (get) Token: 0x06006563 RID: 25955 RVA: 0x0022A68C File Offset: 0x0022888C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06006564 RID: 25956 RVA: 0x0022A69C File Offset: 0x0022889C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContactWarnOnAchievementCompleteSetRequest()
		{
		}

		// Token: 0x06006565 RID: 25957 RVA: 0x0022A6AC File Offset: 0x002288AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContactWarnOnAchievementCompleteSetRequest(ContactWarnOnAchievementCompleteSetRequest other)
		{
		}

		// Token: 0x06006566 RID: 25958 RVA: 0x0022A6BC File Offset: 0x002288BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContactWarnOnAchievementCompleteSetRequest Clone()
		{
			return null;
		}

		// Token: 0x17001257 RID: 4695
		// (get) Token: 0x06006567 RID: 25959 RVA: 0x0022A6CC File Offset: 0x002288CC
		// (set) Token: 0x06006568 RID: 25960 RVA: 0x0022A6DC File Offset: 0x002288DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Enable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06006569 RID: 25961 RVA: 0x0022A6EC File Offset: 0x002288EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600656A RID: 25962 RVA: 0x0022A6FC File Offset: 0x002288FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ContactWarnOnAchievementCompleteSetRequest other)
		{
			return true;
		}

		// Token: 0x0600656B RID: 25963 RVA: 0x0022A70C File Offset: 0x0022890C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600656C RID: 25964 RVA: 0x0022A71C File Offset: 0x0022891C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600656D RID: 25965 RVA: 0x0022A72C File Offset: 0x0022892C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600656E RID: 25966 RVA: 0x0022A73C File Offset: 0x0022893C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600656F RID: 25967 RVA: 0x0022A74C File Offset: 0x0022894C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006570 RID: 25968 RVA: 0x0022A75C File Offset: 0x0022895C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ContactWarnOnAchievementCompleteSetRequest other)
		{
		}

		// Token: 0x06006571 RID: 25969 RVA: 0x0022A76C File Offset: 0x0022896C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006572 RID: 25970 RVA: 0x0022A77C File Offset: 0x0022897C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006573 RID: 25971 RVA: 0x0022A78C File Offset: 0x0022898C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ContactWarnOnAchievementCompleteSetRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					ContactWarnOnAchievementCompleteSetRequest._parser = new MessageParser<ContactWarnOnAchievementCompleteSetRequest>(() => null);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06006574 RID: 25972 RVA: 0x0022A870 File Offset: 0x00228A70
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool U9WLCMJf290P2NDpmx1e()
		{
			return true;
		}

		// Token: 0x06006575 RID: 25973 RVA: 0x0022A878 File Offset: 0x00228A78
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ContactWarnOnAchievementCompleteSetRequest eCWpGQJfEfSNtdlOLscm()
		{
			return null;
		}

		// Token: 0x0400239E RID: 9118
		private static readonly MessageParser<ContactWarnOnAchievementCompleteSetRequest> _parser;

		// Token: 0x0400239F RID: 9119
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023A0 RID: 9120
		public const int EnableFieldNumber = 1;

		// Token: 0x040023A1 RID: 9121
		private bool enable_;

		// Token: 0x040023A2 RID: 9122
		private static ContactWarnOnAchievementCompleteSetRequest U7hc7yJf9K3mYmVYwCg9;
	}
}
