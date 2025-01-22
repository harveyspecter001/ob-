using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B33 RID: 2867
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ShortcutSmiley : IMessage<ShortcutSmiley>, IMessage, IEquatable<ShortcutSmiley>, IDeepCloneable<ShortcutSmiley>, IBufferMessage
	{
		// Token: 0x1700195B RID: 6491
		// (get) Token: 0x06008922 RID: 35106 RVA: 0x00266BF0 File Offset: 0x00264DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShortcutSmiley> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700195C RID: 6492
		// (get) Token: 0x06008923 RID: 35107 RVA: 0x00266C00 File Offset: 0x00264E00
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

		// Token: 0x1700195D RID: 6493
		// (get) Token: 0x06008924 RID: 35108 RVA: 0x00266C10 File Offset: 0x00264E10
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

		// Token: 0x06008925 RID: 35109 RVA: 0x00266C20 File Offset: 0x00264E20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutSmiley()
		{
		}

		// Token: 0x06008926 RID: 35110 RVA: 0x00266C30 File Offset: 0x00264E30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutSmiley(ShortcutSmiley other)
		{
		}

		// Token: 0x06008927 RID: 35111 RVA: 0x00266C40 File Offset: 0x00264E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutSmiley Clone()
		{
			return null;
		}

		// Token: 0x1700195E RID: 6494
		// (get) Token: 0x06008928 RID: 35112 RVA: 0x00266C50 File Offset: 0x00264E50
		// (set) Token: 0x06008929 RID: 35113 RVA: 0x00266C60 File Offset: 0x00264E60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SmileyId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600892A RID: 35114 RVA: 0x00266C70 File Offset: 0x00264E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600892B RID: 35115 RVA: 0x00266C80 File Offset: 0x00264E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ShortcutSmiley other)
		{
			return true;
		}

		// Token: 0x0600892C RID: 35116 RVA: 0x00266C90 File Offset: 0x00264E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600892D RID: 35117 RVA: 0x00266CA0 File Offset: 0x00264EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600892E RID: 35118 RVA: 0x00266CB0 File Offset: 0x00264EB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600892F RID: 35119 RVA: 0x00266CC0 File Offset: 0x00264EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008930 RID: 35120 RVA: 0x00266CD0 File Offset: 0x00264ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008931 RID: 35121 RVA: 0x00266CE0 File Offset: 0x00264EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ShortcutSmiley other)
		{
		}

		// Token: 0x06008932 RID: 35122 RVA: 0x00266CF0 File Offset: 0x00264EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008933 RID: 35123 RVA: 0x00266D00 File Offset: 0x00264F00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008934 RID: 35124 RVA: 0x00266D10 File Offset: 0x00264F10
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ShortcutSmiley()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				ShortcutSmiley._parser = new MessageParser<ShortcutSmiley>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06008935 RID: 35125 RVA: 0x00266DF4 File Offset: 0x00264FF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bXKEfqJdxHusT1NsFKyv()
		{
			return true;
		}

		// Token: 0x06008936 RID: 35126 RVA: 0x00266DFC File Offset: 0x00264FFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ShortcutSmiley TpOoYDJd4kCaiB0lJlf0()
		{
			return null;
		}

		// Token: 0x04003289 RID: 12937
		private static readonly MessageParser<ShortcutSmiley> _parser;

		// Token: 0x0400328A RID: 12938
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400328B RID: 12939
		public const int SmileyIdFieldNumber = 1;

		// Token: 0x0400328C RID: 12940
		private int smileyId_;

		// Token: 0x0400328D RID: 12941
		internal static ShortcutSmiley XFQ4dHJdNTe3x7NRrvf7;
	}
}
