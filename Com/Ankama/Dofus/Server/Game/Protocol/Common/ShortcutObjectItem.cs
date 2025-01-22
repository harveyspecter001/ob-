using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B2F RID: 2863
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ShortcutObjectItem : IMessage<ShortcutObjectItem>, IMessage, IEquatable<ShortcutObjectItem>, IDeepCloneable<ShortcutObjectItem>, IBufferMessage
	{
		// Token: 0x17001952 RID: 6482
		// (get) Token: 0x060088EC RID: 35052 RVA: 0x002667A8 File Offset: 0x002649A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShortcutObjectItem> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001953 RID: 6483
		// (get) Token: 0x060088ED RID: 35053 RVA: 0x002667B8 File Offset: 0x002649B8
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

		// Token: 0x17001954 RID: 6484
		// (get) Token: 0x060088EE RID: 35054 RVA: 0x002667C8 File Offset: 0x002649C8
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

		// Token: 0x060088EF RID: 35055 RVA: 0x002667D8 File Offset: 0x002649D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutObjectItem()
		{
		}

		// Token: 0x060088F0 RID: 35056 RVA: 0x002667E8 File Offset: 0x002649E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutObjectItem(ShortcutObjectItem other)
		{
		}

		// Token: 0x060088F1 RID: 35057 RVA: 0x002667F8 File Offset: 0x002649F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutObjectItem Clone()
		{
			return null;
		}

		// Token: 0x17001955 RID: 6485
		// (get) Token: 0x060088F2 RID: 35058 RVA: 0x00266808 File Offset: 0x00264A08
		// (set) Token: 0x060088F3 RID: 35059 RVA: 0x00266818 File Offset: 0x00264A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemUid
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

		// Token: 0x17001956 RID: 6486
		// (get) Token: 0x060088F4 RID: 35060 RVA: 0x00266828 File Offset: 0x00264A28
		// (set) Token: 0x060088F5 RID: 35061 RVA: 0x00266838 File Offset: 0x00264A38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ItemGid
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

		// Token: 0x060088F6 RID: 35062 RVA: 0x00266848 File Offset: 0x00264A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060088F7 RID: 35063 RVA: 0x00266858 File Offset: 0x00264A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ShortcutObjectItem other)
		{
			return true;
		}

		// Token: 0x060088F8 RID: 35064 RVA: 0x00266868 File Offset: 0x00264A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060088F9 RID: 35065 RVA: 0x00266878 File Offset: 0x00264A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060088FA RID: 35066 RVA: 0x00266888 File Offset: 0x00264A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060088FB RID: 35067 RVA: 0x00266898 File Offset: 0x00264A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060088FC RID: 35068 RVA: 0x002668A8 File Offset: 0x00264AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060088FD RID: 35069 RVA: 0x002668B8 File Offset: 0x00264AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ShortcutObjectItem other)
		{
		}

		// Token: 0x060088FE RID: 35070 RVA: 0x002668C8 File Offset: 0x00264AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060088FF RID: 35071 RVA: 0x002668D8 File Offset: 0x00264AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008900 RID: 35072 RVA: 0x002668E8 File Offset: 0x00264AE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ShortcutObjectItem()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					ShortcutObjectItem._parser = new MessageParser<ShortcutObjectItem>(() => null);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 == 0)
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
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06008901 RID: 35073 RVA: 0x002669CC File Offset: 0x00264BCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WeLBw4Jdd6Opos5egj5Z()
		{
			return true;
		}

		// Token: 0x06008902 RID: 35074 RVA: 0x002669D4 File Offset: 0x00264BD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ShortcutObjectItem a6ev0cJd9SQQOEvMtkei()
		{
			return null;
		}

		// Token: 0x04003279 RID: 12921
		private static readonly MessageParser<ShortcutObjectItem> _parser;

		// Token: 0x0400327A RID: 12922
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400327B RID: 12923
		public const int ItemUidFieldNumber = 1;

		// Token: 0x0400327C RID: 12924
		private int itemUid_;

		// Token: 0x0400327D RID: 12925
		public const int ItemGidFieldNumber = 2;

		// Token: 0x0400327E RID: 12926
		private int itemGid_;

		// Token: 0x0400327F RID: 12927
		internal static ShortcutObjectItem j0ahMKJdspH7q5hO74LY;
	}
}
