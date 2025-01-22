using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B3B RID: 2875
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ShortcutPreset : IMessage<ShortcutPreset>, IMessage, IEquatable<ShortcutPreset>, IDeepCloneable<ShortcutPreset>, IBufferMessage
	{
		// Token: 0x1700196E RID: 6510
		// (get) Token: 0x06008990 RID: 35216 RVA: 0x002674B8 File Offset: 0x002656B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShortcutPreset> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700196F RID: 6511
		// (get) Token: 0x06008991 RID: 35217 RVA: 0x002674C8 File Offset: 0x002656C8
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

		// Token: 0x17001970 RID: 6512
		// (get) Token: 0x06008992 RID: 35218 RVA: 0x002674D8 File Offset: 0x002656D8
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

		// Token: 0x06008993 RID: 35219 RVA: 0x002674E8 File Offset: 0x002656E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutPreset()
		{
		}

		// Token: 0x06008994 RID: 35220 RVA: 0x002674F8 File Offset: 0x002656F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutPreset(ShortcutPreset other)
		{
		}

		// Token: 0x06008995 RID: 35221 RVA: 0x00267508 File Offset: 0x00265708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutPreset Clone()
		{
			return null;
		}

		// Token: 0x17001971 RID: 6513
		// (get) Token: 0x06008996 RID: 35222 RVA: 0x00267518 File Offset: 0x00265718
		// (set) Token: 0x06008997 RID: 35223 RVA: 0x00267528 File Offset: 0x00265728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PresetUuid
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

		// Token: 0x17001972 RID: 6514
		// (get) Token: 0x06008998 RID: 35224 RVA: 0x00267538 File Offset: 0x00265738
		// (set) Token: 0x06008999 RID: 35225 RVA: 0x0026754C File Offset: 0x0026574C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PresetType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (PresetType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600899A RID: 35226 RVA: 0x0026755C File Offset: 0x0026575C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600899B RID: 35227 RVA: 0x0026756C File Offset: 0x0026576C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ShortcutPreset other)
		{
			return true;
		}

		// Token: 0x0600899C RID: 35228 RVA: 0x0026757C File Offset: 0x0026577C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600899D RID: 35229 RVA: 0x0026758C File Offset: 0x0026578C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600899E RID: 35230 RVA: 0x0026759C File Offset: 0x0026579C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600899F RID: 35231 RVA: 0x002675AC File Offset: 0x002657AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060089A0 RID: 35232 RVA: 0x002675BC File Offset: 0x002657BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060089A1 RID: 35233 RVA: 0x002675CC File Offset: 0x002657CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ShortcutPreset other)
		{
		}

		// Token: 0x060089A2 RID: 35234 RVA: 0x002675DC File Offset: 0x002657DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060089A3 RID: 35235 RVA: 0x002675EC File Offset: 0x002657EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060089A4 RID: 35236 RVA: 0x002675FC File Offset: 0x002657FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ShortcutPreset()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					ShortcutPreset._parser = new MessageParser<ShortcutPreset>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x060089A5 RID: 35237 RVA: 0x002676E0 File Offset: 0x002658E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool heoZOtJdarDquEVPrrE5()
		{
			return true;
		}

		// Token: 0x060089A6 RID: 35238 RVA: 0x002676E8 File Offset: 0x002658E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ShortcutPreset zReclgJd5N6tFWmUiBsG()
		{
			return null;
		}

		// Token: 0x040032AB RID: 12971
		private static readonly MessageParser<ShortcutPreset> _parser;

		// Token: 0x040032AC RID: 12972
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032AD RID: 12973
		public const int PresetUuidFieldNumber = 1;

		// Token: 0x040032AE RID: 12974
		private string presetUuid_;

		// Token: 0x040032AF RID: 12975
		public const int TypeFieldNumber = 2;

		// Token: 0x040032B0 RID: 12976
		private PresetType type_;

		// Token: 0x040032B1 RID: 12977
		internal static ShortcutPreset itAcfXJd1DZhXRmuJXS6;
	}
}
