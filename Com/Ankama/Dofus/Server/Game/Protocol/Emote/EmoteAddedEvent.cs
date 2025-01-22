using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Emote
{
	// Token: 0x020007BD RID: 1981
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EmoteAddedEvent : IMessage<EmoteAddedEvent>, IMessage, IEquatable<EmoteAddedEvent>, IDeepCloneable<EmoteAddedEvent>, IBufferMessage
	{
		// Token: 0x1700119A RID: 4506
		// (get) Token: 0x06006110 RID: 24848 RVA: 0x002207F8 File Offset: 0x0021E9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EmoteAddedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700119B RID: 4507
		// (get) Token: 0x06006111 RID: 24849 RVA: 0x00220808 File Offset: 0x0021EA08
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

		// Token: 0x1700119C RID: 4508
		// (get) Token: 0x06006112 RID: 24850 RVA: 0x00220818 File Offset: 0x0021EA18
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

		// Token: 0x06006113 RID: 24851 RVA: 0x00220828 File Offset: 0x0021EA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EmoteAddedEvent()
		{
		}

		// Token: 0x06006114 RID: 24852 RVA: 0x00220838 File Offset: 0x0021EA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EmoteAddedEvent(EmoteAddedEvent other)
		{
		}

		// Token: 0x06006115 RID: 24853 RVA: 0x00220848 File Offset: 0x0021EA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EmoteAddedEvent Clone()
		{
			return null;
		}

		// Token: 0x1700119D RID: 4509
		// (get) Token: 0x06006116 RID: 24854 RVA: 0x00220858 File Offset: 0x0021EA58
		// (set) Token: 0x06006117 RID: 24855 RVA: 0x00220868 File Offset: 0x0021EA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EmoteId
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

		// Token: 0x06006118 RID: 24856 RVA: 0x00220878 File Offset: 0x0021EA78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006119 RID: 24857 RVA: 0x00220888 File Offset: 0x0021EA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(EmoteAddedEvent other)
		{
			return true;
		}

		// Token: 0x0600611A RID: 24858 RVA: 0x00220898 File Offset: 0x0021EA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600611B RID: 24859 RVA: 0x002208A8 File Offset: 0x0021EAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600611C RID: 24860 RVA: 0x002208B8 File Offset: 0x0021EAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600611D RID: 24861 RVA: 0x002208C8 File Offset: 0x0021EAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600611E RID: 24862 RVA: 0x002208D8 File Offset: 0x0021EAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600611F RID: 24863 RVA: 0x002208E8 File Offset: 0x0021EAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(EmoteAddedEvent other)
		{
		}

		// Token: 0x06006120 RID: 24864 RVA: 0x002208F8 File Offset: 0x0021EAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006121 RID: 24865 RVA: 0x00220908 File Offset: 0x0021EB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006122 RID: 24866 RVA: 0x00220918 File Offset: 0x0021EB18
		[MethodImpl(MethodImplOptions.NoInlining)]
		static EmoteAddedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				EmoteAddedEvent._parser = new MessageParser<EmoteAddedEvent>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06006123 RID: 24867 RVA: 0x00220A10 File Offset: 0x0021EC10
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lYn3BQOqF3CjL0dfAODZ()
		{
			return true;
		}

		// Token: 0x06006124 RID: 24868 RVA: 0x00220A18 File Offset: 0x0021EC18
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static EmoteAddedEvent mqloTEOqzgKLndSoPBTE()
		{
			return null;
		}

		// Token: 0x0400221F RID: 8735
		private static readonly MessageParser<EmoteAddedEvent> _parser;

		// Token: 0x04002220 RID: 8736
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002221 RID: 8737
		public const int EmoteIdFieldNumber = 1;

		// Token: 0x04002222 RID: 8738
		private int emoteId_;

		// Token: 0x04002223 RID: 8739
		private static EmoteAddedEvent FNQ0QZOqqdFZkMHC67X4;
	}
}
