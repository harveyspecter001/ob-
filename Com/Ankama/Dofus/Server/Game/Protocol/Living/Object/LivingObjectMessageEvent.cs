using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Living.Object
{
	// Token: 0x020003A2 RID: 930
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LivingObjectMessageEvent : IMessage<LivingObjectMessageEvent>, IMessage, IEquatable<LivingObjectMessageEvent>, IDeepCloneable<LivingObjectMessageEvent>, IBufferMessage
	{
		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06002B97 RID: 11159 RVA: 0x001CAC14 File Offset: 0x001C8E14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<LivingObjectMessageEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06002B98 RID: 11160 RVA: 0x001CAC24 File Offset: 0x001C8E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06002B99 RID: 11161 RVA: 0x001CAC34 File Offset: 0x001C8E34
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

		// Token: 0x06002B9A RID: 11162 RVA: 0x001CAC44 File Offset: 0x001C8E44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LivingObjectMessageEvent()
		{
		}

		// Token: 0x06002B9B RID: 11163 RVA: 0x001CAC54 File Offset: 0x001C8E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LivingObjectMessageEvent(LivingObjectMessageEvent other)
		{
		}

		// Token: 0x06002B9C RID: 11164 RVA: 0x001CAC64 File Offset: 0x001C8E64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LivingObjectMessageEvent Clone()
		{
			return null;
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06002B9D RID: 11165 RVA: 0x001CAC74 File Offset: 0x001C8E74
		// (set) Token: 0x06002B9E RID: 11166 RVA: 0x001CAC84 File Offset: 0x001C8E84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int MessageId
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

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06002B9F RID: 11167 RVA: 0x001CAC94 File Offset: 0x001C8E94
		// (set) Token: 0x06002BA0 RID: 11168 RVA: 0x001CACA4 File Offset: 0x001C8EA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long Timestamp
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06002BA1 RID: 11169 RVA: 0x001CACB4 File Offset: 0x001C8EB4
		// (set) Token: 0x06002BA2 RID: 11170 RVA: 0x001CACC4 File Offset: 0x001C8EC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string OwnerName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06002BA3 RID: 11171 RVA: 0x001CACD4 File Offset: 0x001C8ED4
		// (set) Token: 0x06002BA4 RID: 11172 RVA: 0x001CACE4 File Offset: 0x001C8EE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ObjectGid
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

		// Token: 0x06002BA5 RID: 11173 RVA: 0x001CACF4 File Offset: 0x001C8EF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002BA6 RID: 11174 RVA: 0x001CAD04 File Offset: 0x001C8F04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(LivingObjectMessageEvent other)
		{
			return true;
		}

		// Token: 0x06002BA7 RID: 11175 RVA: 0x001CAD14 File Offset: 0x001C8F14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002BA8 RID: 11176 RVA: 0x001CAD24 File Offset: 0x001C8F24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002BA9 RID: 11177 RVA: 0x001CAD34 File Offset: 0x001C8F34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002BAA RID: 11178 RVA: 0x001CAD44 File Offset: 0x001C8F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002BAB RID: 11179 RVA: 0x001CAD54 File Offset: 0x001C8F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002BAC RID: 11180 RVA: 0x001CAD64 File Offset: 0x001C8F64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(LivingObjectMessageEvent other)
		{
		}

		// Token: 0x06002BAD RID: 11181 RVA: 0x001CAD74 File Offset: 0x001C8F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x001CAD84 File Offset: 0x001C8F84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002BAF RID: 11183 RVA: 0x001CAD94 File Offset: 0x001C8F94
		[MethodImpl(MethodImplOptions.NoInlining)]
		static LivingObjectMessageEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 3:
					return;
				case 4:
					LivingObjectMessageEvent._parser = new MessageParser<LivingObjectMessageEvent>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06002BB0 RID: 11184 RVA: 0x001CAE78 File Offset: 0x001C9078
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CoBvThOVGci9ZmtlYMTB()
		{
			return true;
		}

		// Token: 0x06002BB1 RID: 11185 RVA: 0x001CAE80 File Offset: 0x001C9080
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static LivingObjectMessageEvent wVio2uOVgYErLBFVad1k()
		{
			return null;
		}

		// Token: 0x04000F5A RID: 3930
		private static readonly MessageParser<LivingObjectMessageEvent> _parser;

		// Token: 0x04000F5B RID: 3931
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F5C RID: 3932
		public const int MessageIdFieldNumber = 1;

		// Token: 0x04000F5D RID: 3933
		private int messageId_;

		// Token: 0x04000F5E RID: 3934
		public const int TimestampFieldNumber = 2;

		// Token: 0x04000F5F RID: 3935
		private long timestamp_;

		// Token: 0x04000F60 RID: 3936
		public const int OwnerNameFieldNumber = 3;

		// Token: 0x04000F61 RID: 3937
		private string ownerName_;

		// Token: 0x04000F62 RID: 3938
		public const int ObjectGidFieldNumber = 4;

		// Token: 0x04000F63 RID: 3939
		private int objectGid_;

		// Token: 0x04000F64 RID: 3940
		internal static LivingObjectMessageEvent MXSvOeOVJVLJGJXGFvK5;
	}
}
